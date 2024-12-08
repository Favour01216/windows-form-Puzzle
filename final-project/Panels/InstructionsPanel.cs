using System;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class InstructionsPanel : UserControl
    {
        // Public event to notify when the user wants to go back
        public event EventHandler BackClicked;

        public InstructionsPanel()
        {
            InitializeComponent();
            HookEvents();
        }

        private void HookEvents()
        {
            btnBackFromInstructions.Click += (s, e) => BackClicked?.Invoke(this, EventArgs.Empty);

            // You could dynamically update the instructions text here if needed.
        }
    }
}
