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
            this.components = new System.ComponentModel.Container();
            this.btnBackToGame = new System.Windows.Forms.Button();
            this.picReference = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelPuzzle = new System.Windows.Forms.TableLayoutPanel();
            this.lblPuzzleTimer = new System.Windows.Forms.Label();
            this.btnSavePuzzle = new System.Windows.Forms.Button();
            this.puzzleTimer = new System.Windows.Forms.Timer(this.components);
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
            this.btnBackToGame.Size = new System.Drawing.Size(132, 30);
            this.btnBackToGame.TabIndex = 0;
            this.btnBackToGame.Text = "Back to Game";
            this.btnBackToGame.UseVisualStyleBackColor = false;
            this.btnBackToGame.Click += new System.EventHandler(this.BtnBackToGame_Click);
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
            // lblPuzzleTimer
            // 
            this.lblPuzzleTimer.AutoSize = true;
            this.lblPuzzleTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPuzzleTimer.ForeColor = System.Drawing.Color.Black;
            this.lblPuzzleTimer.Location = new System.Drawing.Point(15, 502);
            this.lblPuzzleTimer.Name = "lblPuzzleTimer";
            this.lblPuzzleTimer.Size = new System.Drawing.Size(124, 28);
            this.lblPuzzleTimer.TabIndex = 4;
            this.lblPuzzleTimer.Text = "Timer: 120s";
            // 
            // btnSavePuzzle
            // 
            this.btnSavePuzzle.BackColor = System.Drawing.Color.LightYellow;
            this.btnSavePuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePuzzle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSavePuzzle.Location = new System.Drawing.Point(600, 500);
            this.btnSavePuzzle.Name = "btnSavePuzzle";
            this.btnSavePuzzle.Size = new System.Drawing.Size(113, 30);
            this.btnSavePuzzle.TabIndex = 5;
            this.btnSavePuzzle.Text = "Save Puzzle";
            this.btnSavePuzzle.UseVisualStyleBackColor = false;
            this.btnSavePuzzle.Click += new System.EventHandler(this.BtnSavePuzzle_Click);
            // 
            // puzzleTimer
            // 
            this.puzzleTimer.Enabled = true;
            this.puzzleTimer.Interval = 1000;
            // 
            // PicturePuzzlePanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnBackToGame);
            this.Controls.Add(this.picReference);
            this.Controls.Add(this.tableLayoutPanelPuzzle);
            this.Controls.Add(this.lblPuzzleTimer);
            this.Controls.Add(this.btnSavePuzzle);
            this.Name = "PicturePuzzlePanel";
            ((System.ComponentModel.ISupportInitialize)(this.picReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Timer puzzleTimer;
    }
}
