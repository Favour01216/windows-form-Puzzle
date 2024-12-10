using System;
using System.Windows.Forms;
using final_project.Utilities;

namespace final_project.Panels
{
    public partial class GamePanel : Form
    {
        private GameManager gameManager;
        private int timeRemaining;

        public GamePanel(GameManager manager)
        {
            InitializeComponent();
            gameManager = manager ?? throw new ArgumentNullException(nameof(manager), "GameManager cannot be null.");
            StartNewPuzzle();
        }

        private void StartNewPuzzle()
        {
            if (gameManager.IsGameOver())
            {
                ShowGameOverPanel();
                return;
            }

            var currentPeriod = gameManager.GetCurrentTimePeriod();
            var currentPuzzle = currentPeriod?.Puzzles.Find(p => !p.IsSolved);

            if (currentPuzzle == null)
            {
                gameManager.AdvanceToNextPeriod();
                StartNewPuzzle();
                return;
            }

            lblTimePeriod.Text = currentPeriod.Name;
            lblDescription.Text = currentPeriod.Description;
            lblQuestion.Text = currentPuzzle.Question;

            ResetTimer();
        }

        private void ResetTimer()
        {
            timeRemaining = 60;
            lblTimer.Text = $"Time Left: {timeRemaining}s";

            if (!timer.Enabled)
            {
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                lblTimer.Text = $"Time Left: {timeRemaining}s";
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time's up! Moving to the next puzzle.", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StartNewPuzzle();
            }
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            var currentPeriod = gameManager.GetCurrentTimePeriod();
            var currentPuzzle = currentPeriod?.Puzzles.Find(p => !p.IsSolved);

            if (currentPuzzle == null)
            {
                MessageBox.Show("No active puzzle to submit an answer for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userAnswer = txtAnswer.Text.Trim();

            if (currentPuzzle.CheckAnswer(userAnswer))
            {
                gameManager.Player.AddScore(10);
                lblScore.Text = $"Score: {gameManager.Player.Score}";
                timer.Stop();

                MessageBox.Show("Correct answer! Moving to the next puzzle.", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartNewPuzzle();
            }
            else
            {
                MessageBox.Show("Incorrect answer. Please try again.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtAnswer.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StartNewPuzzle();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ReturnToMainMenu();
        }

        private void ShowGameOverPanel()
        {
            this.Hide();
            GameOverPanel gameOverPanel = new GameOverPanel(gameManager);
            gameOverPanel.Show();
        }

        private void ReturnToMainMenu()
        {
            this.Hide();
            var mainMenu = new MainMenuPanel();
            mainMenu.Show();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            gameManager.LoadGame();
            lblScore.Text = $"Score: {gameManager.Player.Score}";
            MessageBox.Show("Game loaded! Resetting progress.", "Game Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StartNewPuzzle();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            gameManager.SaveGame();
            timer.Stop();
            MessageBox.Show("Game saved! Showing Game Over panel.", "Game Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowGameOverPanel();
        }
    }
}
