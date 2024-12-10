using final_project.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class MainMenuPanel : Form
    {
        private GameManager gameManager;
        public MainMenuPanel()
        {
            InitializeComponent();
            InitializeGameManager();
        }

        private void InitializeGameManager()
        {
            // Initialize the GameManager with a default player name.
            gameManager = new GameManager("Player1");
        }


        // Method triggered when "Start Game" button is clicked.  
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            GamePanel gamePanel = new GamePanel(gameManager);
            this.Hide();
            gamePanel.Show();

        }

        // Method triggered when "Instructions" button is clicked.  
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            InstructionsPanel instructionsPanel = new InstructionsPanel();
            this.Hide();
            instructionsPanel.Show();

        }
        // Method triggered when "Exit" button is clicked.  

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Confirm before exiting the application.  
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}  

