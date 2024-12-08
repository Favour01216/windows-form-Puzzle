namespace final_project.Panels
{
    partial class MainMenuPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblTitle.Location = new System.Drawing.Point(0, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 60); // Fixed width here, adjust as needed
            this.lblTitle.Text = "Time Traveler\'s Puzzle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.AutoSize = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnStartGame.BackColor = System.Drawing.Color.LightBlue;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Set a fixed initial location (no dynamic code)
            this.btnStartGame.Location = new System.Drawing.Point(300, 200);
            this.btnStartGame.Size = new System.Drawing.Size(200, 50);
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Name = "btnStartGame";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnInstructions.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Fixed initial location
            this.btnInstructions.Location = new System.Drawing.Point(300, 270);
            this.btnInstructions.Size = new System.Drawing.Size(200, 50);
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Name = "btnInstructions";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Fixed initial location
            this.btnExit.Location = new System.Drawing.Point(300, 340);
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Name = "btnExit";
            // 
            // MainMenuPanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnExit);
            this.Name = "MainMenuPanel";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
        }
    }
}
