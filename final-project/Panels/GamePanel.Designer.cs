using System.Windows.Forms;

namespace final_project.Panels
{
    partial class GamePanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.Button btnPicturePuzzle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.btnPicturePuzzle = new System.Windows.Forms.Button();
            this.BtnBackToMainMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(20, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(87, 28);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(650, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(146, 28);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Time Left: 60s";
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTimePeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTimePeriod.Location = new System.Drawing.Point(20, 80);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(280, 41);
            this.lblTimePeriod.TabIndex = 2;
            this.lblTimePeriod.Text = "Renaissance Period";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(20, 120);
            this.lblDescription.MaximumSize = new System.Drawing.Size(760, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(457, 28);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "A period of great cultural change and achievement.";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(20, 180);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(760, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(320, 32);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Who painted the Mona Lisa?";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.Location = new System.Drawing.Point(20, 230);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(300, 34);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(330, 230);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(100, 34);
            this.btnSubmitAnswer.TabIndex = 6;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = false;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.Location = new System.Drawing.Point(20, 280);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 33);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFeedback.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFeedback.Location = new System.Drawing.Point(140, 285);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 28);
            this.lblFeedback.TabIndex = 8;
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.LightYellow;
            this.btnSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveGame.Location = new System.Drawing.Point(20, 500);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(100, 57);
            this.btnSaveGame.TabIndex = 9;
            this.btnSaveGame.Text = "Save Game";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.LightYellow;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoadGame.Location = new System.Drawing.Point(130, 500);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(100, 57);
            this.btnLoadGame.TabIndex = 10;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnPicturePuzzle
            // 
            this.btnPicturePuzzle.BackColor = System.Drawing.Color.LightCoral;
            this.btnPicturePuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicturePuzzle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPicturePuzzle.Location = new System.Drawing.Point(650, 500);
            this.btnPicturePuzzle.Name = "btnPicturePuzzle";
            this.btnPicturePuzzle.Size = new System.Drawing.Size(129, 57);
            this.btnPicturePuzzle.TabIndex = 11;
            this.btnPicturePuzzle.Text = "Picture Puzzle";
            this.btnPicturePuzzle.UseVisualStyleBackColor = false;
            this.btnPicturePuzzle.Click += new System.EventHandler(this.btnPicturePuzzle_Click);
            // 
            // BtnBackToMainMenu
            // 
            this.BtnBackToMainMenu.BackColor = System.Drawing.Color.LightYellow;
            this.BtnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnBackToMainMenu.Location = new System.Drawing.Point(236, 500);
            this.BtnBackToMainMenu.Name = "BtnBackToMainMenu";
            this.BtnBackToMainMenu.Size = new System.Drawing.Size(100, 57);
            this.BtnBackToMainMenu.TabIndex = 10;
            this.BtnBackToMainMenu.Text = "Back";
            this.BtnBackToMainMenu.UseVisualStyleBackColor = false;
            this.BtnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GamePanel
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 595);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimePeriod);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSaveGame);
            this.Controls.Add(this.BtnBackToMainMenu);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnPicturePuzzle);
            this.Name = "GamePanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button BtnBackToMainMenu;
        private Timer timer;
    }
}
