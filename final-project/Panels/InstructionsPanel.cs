using System;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class InstructionsPanel : Form
    {
        public InstructionsPanel()
        {
            InitializeComponent();
        }

        // Method triggered when "Back" button is clicked.  
        private void btnBackFromInstructions_Click(object sender, EventArgs e)
        {
            // Hide the current Instructions Panel.  
            this.Hide();

            // Return to the Main Menu Panel.  
            try
            {
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