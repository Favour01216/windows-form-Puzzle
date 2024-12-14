using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using final_project.Utilities;

namespace final_project.Panels
{
    public partial class PicturePuzzlePanel : Form
    {
        private GameManager gameManager;
        private List<PictureBox> puzzleTiles = new List<PictureBox>();
        private List<Bitmap> images = new List<Bitmap>();
        private string winState = string.Empty;
        private string currentState = string.Empty;
        private Bitmap mainBitmap;
        private int gridSize = 3; // Grid size (3x3).  
        private int tileSize = 130; // Size of each tile.  
        private int timeRemaining = 120; // 2 minutes in seconds.  

        public PicturePuzzlePanel(GameManager manager)
        {
            InitializeComponent();
            gameManager = manager ?? throw new ArgumentNullException(nameof(manager), "GameManager cannot be null.");

            InitializePuzzle();
            StartPuzzleTimer();
        }

        private void InitializePuzzle()
        {
            LoadPuzzleImage();
            CreatePictureBoxes();
            CropAndAssignImages();
            ShufflePuzzleTiles();
            DisplayReferenceImage();
        }

        private void LoadPuzzleImage()
        {
            // Replace with your logic to select a puzzle image or use a predefined image.  
            mainBitmap = Properties.Resources.Puzzle;
        }

        private void CreatePictureBoxes()
        {
            puzzleTiles.Clear();

            for (int i = 0; i < gridSize * gridSize; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(tileSize, tileSize),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.Gold,
                    Tag = i.ToString() // Assign initial tag to match the correct order.  
                };

                pictureBox.Click += OnTileClick;
                puzzleTiles.Add(pictureBox);
            }
        }

        private void CropAndAssignImages()
        {
            images.Clear();

            // Resize the main image and crop it into tiles.  
            Bitmap resizedImage = new Bitmap(mainBitmap, new Size(tileSize * gridSize, tileSize * gridSize));
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Bitmap croppedImage = resizedImage.Clone(
                        new Rectangle(col * tileSize, row * tileSize, tileSize, tileSize),
                        resizedImage.PixelFormat);
                    images.Add(croppedImage);
                }
            }

            // Assign images to tiles, leaving the top-left corner empty.  
            for (int i = 0; i < puzzleTiles.Count; i++)
            {
                puzzleTiles[i].BackgroundImage = i == 0 ? null : images[i];
                puzzleTiles[i].Tag = i.ToString(); // Assign unique tags for each tile.  
            }

            winState = string.Join("", puzzleTiles.Select(t => t.Tag.ToString()));
        }

        private void ShufflePuzzleTiles()
        {
            var shuffledTiles = puzzleTiles.OrderBy(x => Guid.NewGuid()).ToList();

            // Ensure the empty tile (top-left) stays at the first position.  
            var emptyTile = shuffledTiles.First(t => t.BackgroundImage == null);
            shuffledTiles.Remove(emptyTile);
            shuffledTiles.Insert(0, emptyTile);

            DisplayTiles(shuffledTiles);
        }

        private void DisplayTiles(List<PictureBox> tiles)
        {
            tableLayoutPanelPuzzle.Controls.Clear();
            tableLayoutPanelPuzzle.RowCount = gridSize;
            tableLayoutPanelPuzzle.ColumnCount = gridSize;

            foreach (var tile in tiles)
            {
                tableLayoutPanelPuzzle.Controls.Add(tile);
            }
        }

        private void DisplayReferenceImage()
        {
            picReference.Image = mainBitmap; // Display the reference image in the designated PictureBox.  
            picReference.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void StartPuzzleTimer()
        {
            puzzleTimer.Interval = 1000; // Set interval to 1 second.  
            puzzleTimer.Tick += PuzzleTimer_Tick;
            puzzleTimer.Start();

            UpdateTimerLabel();
        }

        private void PuzzleTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                UpdateTimerLabel();
            }
            else
            {
                puzzleTimer.Stop();
                MessageBox.Show("Time's up! Returning to the Game Panel.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnBackToGame_Click(this, EventArgs.Empty);
            }
        }

        private void UpdateTimerLabel()
        {
            int minutes = timeRemaining / 60;
            int seconds = timeRemaining % 60;
            lblPuzzleTimer.Text = $"Time Left: {minutes:00}:{seconds:00}";
        }

        private void OnTileClick(object sender, EventArgs e)
        {
            PictureBox clickedTile = sender as PictureBox;
            PictureBox emptyTile = puzzleTiles.Find(tile => tile.BackgroundImage == null);

            if (emptyTile != null && IsAdjacent(clickedTile, emptyTile))
            {
                // Swap images and tags.  
                emptyTile.BackgroundImage = clickedTile.BackgroundImage;
                clickedTile.BackgroundImage = null;

                string tempTag = clickedTile.Tag.ToString();
                clickedTile.Tag = emptyTile.Tag;
                emptyTile.Tag = tempTag;

                CheckCompletion();
            }
        }

        private bool IsAdjacent(PictureBox tile1, PictureBox tile2)
        {
            int index1 = tableLayoutPanelPuzzle.Controls.GetChildIndex(tile1);
            int index2 = tableLayoutPanelPuzzle.Controls.GetChildIndex(tile2);

            int rowDiff = Math.Abs(index1 / gridSize - index2 / gridSize);
            int colDiff = Math.Abs(index1 % gridSize - index2 % gridSize);

            return (rowDiff == 1 && colDiff == 0) || (rowDiff == 0 && colDiff == 1);
        }

        private void CheckCompletion()
        {
            currentState = string.Join("", puzzleTiles.Select(t => t.Tag.ToString()));
        }

        private void BtnSavePuzzle_Click(object sender, EventArgs e)
        {
            puzzleTimer.Stop();

            gameManager.SaveGame();

            if (winState == currentState)
            {
                gameManager.Player.AddScore(50); // Award full points for solving the puzzle.  
                MessageBox.Show($"Puzzle Solved! You've earned 50 points.\nTotal Score: {gameManager.Player.Score}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnBackToGame_Click(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Almost there! Keep going to solve the puzzle.", "Keep Trying", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puzzleTimer.Start();
            }
        }

        private void BtnBackToGame_Click(object sender, EventArgs e)
        {
            puzzleTimer.Stop();
            this.Hide();
            GamePanel gamePanel = new GamePanel(gameManager);
            gamePanel.Show();
        }
    }
}
