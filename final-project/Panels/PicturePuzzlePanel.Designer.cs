using System;
using System.Drawing;   // Required for Font, Point, Size
using System.Windows.Forms;

namespace final_project.Panels
{
    partial class PicturePuzzlePanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBackToGame;
        private System.Windows.Forms.PictureBox picReference;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPuzzle;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblPuzzleTimer;
        private System.Windows.Forms.Button btnSavePuzzle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBackToGame = new System.Windows.Forms.Button();
            this.picReference = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelPuzzle = new System.Windows.Forms.TableLayoutPanel();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lblPuzzleTimer = new System.Windows.Forms.Label();
            this.btnSavePuzzle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picReference)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackToGame
            // 
            this.btnBackToGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBackToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBackToGame.Location = new System.Drawing.Point(20, 20);
            this.btnBackToGame.Name = "btnBackToGame";
            this.btnBackToGame.Size = new System.Drawing.Size(120, 30);
            this.btnBackToGame.TabIndex = 0;
            this.btnBackToGame.Text = "Back to Game";
            this.btnBackToGame.UseVisualStyleBackColor = false;
            // 
            // picReference
            // 
            this.picReference.BackColor = System.Drawing.Color.White;
            this.picReference.Location = new System.Drawing.Point(20, 70);
            this.picReference.Name = "picReference";
            this.picReference.Size = new System.Drawing.Size(200, 200);
            this.picReference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReference.TabIndex = 1;
            this.picReference.TabStop = false;
            // 
            // tableLayoutPanelPuzzle
            // 
            this.tableLayoutPanelPuzzle.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelPuzzle.ColumnCount = 3;
            this.tableLayoutPanelPuzzle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanelPuzzle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanelPuzzle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelPuzzle.Location = new System.Drawing.Point(240, 70);
            this.tableLayoutPanelPuzzle.Name = "tableLayoutPanelPuzzle";
            this.tableLayoutPanelPuzzle.RowCount = 3;
            this.tableLayoutPanelPuzzle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelPuzzle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanelPuzzle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelPuzzle.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanelPuzzle.TabIndex = 2;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.LightYellow;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnShuffle.Location = new System.Drawing.Point(20, 500);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(100, 30);
            this.btnShuffle.TabIndex = 3;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            // 
            // lblPuzzleTimer
            // 
            this.lblPuzzleTimer.AutoSize = true;
            this.lblPuzzleTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuzzleTimer.ForeColor = System.Drawing.Color.Black;
            this.lblPuzzleTimer.Location = new System.Drawing.Point(140, 505);
            this.lblPuzzleTimer.Name = "lblPuzzleTimer";
            this.lblPuzzleTimer.Size = new System.Drawing.Size(112, 28);
            this.lblPuzzleTimer.TabIndex = 4;
            this.lblPuzzleTimer.Text = "Timer: 60s";
            // 
            // btnSavePuzzle
            // 
            this.btnSavePuzzle.BackColor = System.Drawing.Color.LightYellow;
            this.btnSavePuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePuzzle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSavePuzzle.Location = new System.Drawing.Point(600, 500);
            this.btnSavePuzzle.Name = "btnSavePuzzle";
            this.btnSavePuzzle.Size = new System.Drawing.Size(100, 30);
            this.btnSavePuzzle.TabIndex = 5;
            this.btnSavePuzzle.Text = "Save Puzzle";
            this.btnSavePuzzle.UseVisualStyleBackColor = false;
            // 
            // PicturePuzzlePanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnBackToGame);
            this.Controls.Add(this.picReference);
            this.Controls.Add(this.tableLayoutPanelPuzzle);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblPuzzleTimer);
            this.Controls.Add(this.btnSavePuzzle);
            this.Name = "PicturePuzzlePanel";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.picReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
