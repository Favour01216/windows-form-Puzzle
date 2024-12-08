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
    public partial class MainMenuPanel : UserControl
    {
        public event EventHandler StartGameClicked;
        public event EventHandler InstructionsClicked;
        public event EventHandler ExitClicked;

        public MainMenuPanel()
        {
            InitializeComponent();
            HookEvents();
            // Subscribe to Resize event after InitializeComponent
            this.Resize += (s, e) => OnResizePanel();
        }

        private void HookEvents()
        {
            btnStartGame.Click += (s, e) => StartGameClicked?.Invoke(this, EventArgs.Empty);
            btnInstructions.Click += (s, e) => InstructionsClicked?.Invoke(this, EventArgs.Empty);
            btnExit.Click += (s, e) => ExitClicked?.Invoke(this, EventArgs.Empty);

            btnStartGame.MouseEnter += (s, e) => btnStartGame.BackColor = System.Drawing.Color.LightCyan;
            btnStartGame.MouseLeave += (s, e) => btnStartGame.BackColor = System.Drawing.Color.LightBlue;

            btnInstructions.MouseEnter += (s, e) => btnInstructions.BackColor = System.Drawing.Color.PaleGreen;
            btnInstructions.MouseLeave += (s, e) => btnInstructions.BackColor = System.Drawing.Color.LightGreen;

            btnExit.MouseEnter += (s, e) => btnExit.BackColor = System.Drawing.Color.IndianRed;
            btnExit.MouseLeave += (s, e) => btnExit.BackColor = System.Drawing.Color.LightCoral;
        }

        private void OnResizePanel()
        {
            // Center controls dynamically at runtime
            lblTitle.Width = this.Width;
            btnStartGame.Left = (this.Width - btnStartGame.Width) / 2;
            btnInstructions.Left = (this.Width - btnInstructions.Width) / 2;
            btnExit.Left = (this.Width - btnExit.Width) / 2;
        }
    }
}
