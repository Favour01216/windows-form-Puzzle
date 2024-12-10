using final_project.Panels;
using final_project.Utilities;
using System;
using System.Windows.Forms;

namespace final_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        // Method to initialize and configure the MainForm settings.  
        private void InitializeMainForm()
        {
            // Set the form title and size.  
            this.Text = "Time Traveler's Puzzle";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);

            // Load the Main Menu Panel as the initial screen.  
            LoadMainMenu();
        }

        // Method to load the Main Menu Panel.  
        private void LoadMainMenu()
        {
            try
            {
                MainMenuPanel mainMenu = new MainMenuPanel();
                mainMenu.TopLevel = false; // Allows the panel to be embedded in the MainForm.  
                mainMenu.FormBorderStyle = FormBorderStyle.None;
                mainMenu.Dock = DockStyle.Fill;

                this.Controls.Clear(); // Clear any existing controls.  
                this.Controls.Add(mainMenu);
                mainMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Main Menu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Optional: Method to load other panels dynamically, if needed.  
        public void LoadPanel(Form panel)
        {
            try
            {
                panel.TopLevel = false;
                panel.FormBorderStyle = FormBorderStyle.None;
                panel.Dock = DockStyle.Fill;

                this.Controls.Clear();
                this.Controls.Add(panel);
                panel.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading panel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}