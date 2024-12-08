using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class PicturePuzzlePanel : UserControl
    {
        public event EventHandler BackToGameClicked;
        public event EventHandler ShuffleClicked;
        public event EventHandler SavePuzzleClicked;

        public PicturePuzzlePanel()
        {
            InitializeComponent();
            HookEvents();
            this.Resize += (s, e) => OnResizePanel();
        }

        private void HookEvents()
        {
            btnBackToGame.Click += (s, e) => BackToGameClicked?.Invoke(this, EventArgs.Empty);
            btnShuffle.Click += (s, e) => ShuffleClicked?.Invoke(this, EventArgs.Empty);
            btnSavePuzzle.Click += (s, e) => SavePuzzleClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShuffleTiles()
        {
            // Implement shuffle logic if needed
        }

        public void UpdatePuzzleTimer(int secondsLeft)
        {
            lblPuzzleTimer.Text = $"Timer: {secondsLeft}s";
        }

        public void SavePuzzleState()
        {
            // Implement save puzzle logic if needed
        }

        public void LoadPuzzleState()
        {
            // Implement load puzzle logic if needed
        }

        public bool IsPuzzleComplete()
        {
            // Check puzzle completion if needed
            return false;
        }

        private void OnResizePanel()
        {
            // Dynamically adjust the size and positions of controls at runtime
            // Adjust tableLayoutPanelPuzzle based on current panel size
            tableLayoutPanelPuzzle.Width = this.Width - 260;
            tableLayoutPanelPuzzle.Height = this.Height - 160;

            // Position Shuffle, Timer, and SavePuzzle buttons at bottom
            btnShuffle.Top = this.Height - 60;
            lblPuzzleTimer.Top = this.Height - 55;
            btnSavePuzzle.Top = this.Height - 60;
            btnSavePuzzle.Left = this.Width - 120;
        }
    }
}
