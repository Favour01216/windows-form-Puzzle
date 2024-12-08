using System.Drawing;
using System.Windows.Forms;

namespace final_project.Panels
{
    partial class GameOverPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCongratulations;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnMainMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCongratulations = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCongratulations
            // 
            this.lblCongratulations.AutoSize = true;
            this.lblCongratulations.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblCongratulations.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblCongratulations.Location = new System.Drawing.Point(100, 100);
            this.lblCongratulations.Name = "lblCongratulations";
            this.lblCongratulations.Size = new System.Drawing.Size(335, 45);
            this.lblCongratulations.TabIndex = 0;
            this.lblCongratulations.Text = "Congratulations, Player!";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblFinalScore.ForeColor = System.Drawing.Color.DimGray;
            this.lblFinalScore.Location = new System.Drawing.Point(100, 180);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(224, 32);
            this.lblFinalScore.TabIndex = 1;
            this.lblFinalScore.Text = "Your Final Score: 0";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPlayAgain.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Location = new System.Drawing.Point(100, 300);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(150, 50);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMainMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Location = new System.Drawing.Point(260, 300);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(150, 50);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            // 
            // GameOverPanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblCongratulations);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "GameOverPanel";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
