using final_project.Utilities;
using System;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class GameOverPanel : Form
    {
        private GameManager gameManager;

        public GameOverPanel(GameManager manager)
        {
            InitializeComponent();
            gameManager = manager ?? throw new ArgumentNullException(nameof(manager), "GameManager cannot be null.");

            // Display the final score.  
            lblFinalScore.Text = $"Your Final Score: {gameManager.Player.Score}";
        }

        // Method triggered when "Play Again" button is clicked.  
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            try
            {
                // Restart the game with the same player name.  
                gameManager = new GameManager(gameManager.Player.Name);

                // Hide the current panel and start a new game.  
                this.Hide();
                GamePanel gamePanel = new GamePanel(gameManager);
                gamePanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restarting the game: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method triggered when "Return to Main Menu" button is clicked.  
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide the current Game Over Panel and return to Main Menu.  
                this.Hide();

                MainMenuPanel mainMenuPanel = new MainMenuPanel();
                mainMenuPanel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning to Main Menu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
