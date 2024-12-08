using final_project.Panels;
using final_project.Utilities;
using System;
using System.Windows.Forms;


namespace final_project
{
    public partial class MainForm : Form
    {
        // Panel Instances
        private MainMenuPanel mainMenuPanel;
        private InstructionsPanel instructionsPanel;
        private GamePanel gamePanel;
        private PicturePuzzlePanel picturePuzzlePanel;
        private GameOverPanel gameOverPanel;

        public MainForm()
        {
            InitializeComponent();
            InitializePanels();
            ShowMainMenu();
        }

        private void InitializePanels()
        {
            mainMenuPanel = new MainMenuPanel();
            instructionsPanel = new InstructionsPanel();
            gamePanel = new GamePanel();
            picturePuzzlePanel = new PicturePuzzlePanel();
            gameOverPanel = new GameOverPanel();

            mainMenuPanel.Dock = DockStyle.Fill;
            instructionsPanel.Dock = DockStyle.Fill;
            gamePanel.Dock = DockStyle.Fill;
            picturePuzzlePanel.Dock = DockStyle.Fill;
            gameOverPanel.Dock = DockStyle.Fill;

            this.Controls.Add(mainMenuPanel);
            this.Controls.Add(instructionsPanel);
            this.Controls.Add(gamePanel);
            this.Controls.Add(picturePuzzlePanel);
            this.Controls.Add(gameOverPanel);

            // Subscribe to panel events here if needed, e.g.:
            // mainMenuPanel.StartGameClicked += (s, e) => ShowGamePanel();
        }

        private void ShowMainMenu()
        {
            HideAllPanels();
            mainMenuPanel.Visible = true;
            mainMenuPanel.BringToFront();
        }

        private void ShowInstructions()
        {
            HideAllPanels();
            instructionsPanel.Visible = true;
            instructionsPanel.BringToFront();
        }

        private void ShowGamePanel()
        {
            HideAllPanels();
            gamePanel.Visible = true;
            gamePanel.BringToFront();
        }

        private void ShowPicturePuzzle()
        {
            HideAllPanels();
            picturePuzzlePanel.Visible = true;
            picturePuzzlePanel.BringToFront();
        }

        private void ShowGameOver()
        {
            HideAllPanels();
            gameOverPanel.Visible = true;
            gameOverPanel.BringToFront();
        }

        private void HideAllPanels()
        {
            mainMenuPanel.Visible = false;
            instructionsPanel.Visible = false;
            gamePanel.Visible = false;
            picturePuzzlePanel.Visible = false;
            gameOverPanel.Visible = false;
        }
    }
}
