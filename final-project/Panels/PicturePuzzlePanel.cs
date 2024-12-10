using final_project.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class PicturePuzzlePanel : Form
    {
        private GameManager gameManager;

        public PicturePuzzlePanel(GameManager manager)
        {
            InitializeComponent();
            gameManager = manager ?? throw new ArgumentNullException(nameof(manager), "GameManager cannot be null.");
        }

        // Method triggered when "Shuffle" button is clicked.  
        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            // Implement logic to shuffle puzzle tiles.  
            MessageBox.Show("The tiles have been shuffled.", "Shuffle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method triggered when "Save Puzzle" button is clicked.  
        private void BtnSavePuzzle_Click(object sender, EventArgs e)
        {
            gameManager.SaveGame();
            // Implement logic to save the current puzzle state.  
            MessageBox.Show("The current puzzle state has been saved.", "Save Puzzle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method triggered when "Back to Game" button is clicked.  
        private void BtnBackToGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePanel gamePanel = new GamePanel(gameManager);
            gamePanel.Show();
        }
    }
}
