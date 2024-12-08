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
    public partial class GameOverPanel : UserControl
    {
        public event EventHandler PlayAgainClicked;
        public event EventHandler MainMenuClicked;

        public GameOverPanel()
        {
            InitializeComponent();
            HookEvents();
        }

        private void HookEvents()
        {
            btnPlayAgain.Click += (s, e) => PlayAgainClicked?.Invoke(this, EventArgs.Empty);
            btnMainMenu.Click += (s, e) => MainMenuClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetFinalScore(string playerName, int score)
        {
            lblCongratulations.Text = $"Congratulations, {playerName}!";
            lblFinalScore.Text = $"Your Final Score: {score}";
            // Trigger a manual resize to recenter elements after updating text
            OnResizePanel();
        }

        private void OnResizePanel()
        {
            // Center lblCongratulations horizontally
            lblCongratulations.Left = (this.Width - lblCongratulations.Width) / 2;
            // Position lblFinalScore below lblCongratulations, also centered
            lblFinalScore.Left = (this.Width - lblFinalScore.Width) / 2;
            lblFinalScore.Top = lblCongratulations.Bottom + 20;

            // Position buttons horizontally centered, with spacing
            btnPlayAgain.Top = lblFinalScore.Bottom + 100;
            btnMainMenu.Top = btnPlayAgain.Top;

            int totalButtonsWidth = btnPlayAgain.Width + 30 + btnMainMenu.Width;
            int startX = (this.Width - totalButtonsWidth) / 2;
            btnPlayAgain.Left = startX;
            btnMainMenu.Left = btnPlayAgain.Right + 30;
        }
    }
}
