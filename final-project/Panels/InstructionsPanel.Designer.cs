using System;
using System.Drawing;   // Needed for Font, Point, Size
using System.Windows.Forms;

namespace final_project.Panels
{
    partial class InstructionsPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInstructionsTitle;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Button btnBackFromInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInstructionsTitle = new System.Windows.Forms.Label();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.btnBackFromInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructionsTitle
            // 
            this.lblInstructionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInstructionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblInstructionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstructionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblInstructionsTitle.Name = "lblInstructionsTitle";
            this.lblInstructionsTitle.Size = new System.Drawing.Size(800, 60);
            this.lblInstructionsTitle.TabIndex = 0;
            this.lblInstructionsTitle.Text = "How to Play";
            this.lblInstructionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.BackColor = System.Drawing.Color.White;
            this.rtbInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInstructions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rtbInstructions.Location = new System.Drawing.Point(50, 80);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(600, 300);
            this.rtbInstructions.TabIndex = 1;
            this.rtbInstructions.Text = "- You are a time traveler fixing anomalies.\n- Solve puzzles related to each perio" +
    "d.\n- Enter your answer and submit.\n- Complete all puzzles to win.\n";
            // 
            // btnBackFromInstructions
            // 
            this.btnBackFromInstructions.AutoSize = true;
            this.btnBackFromInstructions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBackFromInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromInstructions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBackFromInstructions.Location = new System.Drawing.Point(250, 400);
            this.btnBackFromInstructions.Name = "btnBackFromInstructions";
            this.btnBackFromInstructions.Size = new System.Drawing.Size(100, 40);
            this.btnBackFromInstructions.TabIndex = 2;
            this.btnBackFromInstructions.Text = "Back";
            this.btnBackFromInstructions.UseVisualStyleBackColor = false;
            // 
            // InstructionsPanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblInstructionsTitle);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.btnBackFromInstructions);
            this.Name = "InstructionsPanel";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
