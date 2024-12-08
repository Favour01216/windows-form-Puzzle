using System;
using final_project.Utilities;
using System.Windows.Forms;

namespace final_project.Panels
{
    public partial class GamePanel : UserControl
    {
        // Public events for various actions
        public event EventHandler SubmitAnswerClicked;
        public event EventHandler NextClicked;
        public event EventHandler SaveGameClicked;
        public event EventHandler LoadGameClicked;
        public event EventHandler PicturePuzzleClicked;

        public GamePanel()
        {
            InitializeComponent();
            HookEvents();
        }

        private void HookEvents()
        {
            btnSubmitAnswer.Click += (s, e) => SubmitAnswerClicked?.Invoke(this, EventArgs.Empty);
            btnNext.Click += (s, e) => NextClicked?.Invoke(this, EventArgs.Empty);
            btnSaveGame.Click += (s, e) => SaveGameClicked?.Invoke(this, EventArgs.Empty);
            btnLoadGame.Click += (s, e) => LoadGameClicked?.Invoke(this, EventArgs.Empty);
            btnPicturePuzzle.Click += (s, e) => PicturePuzzleClicked?.Invoke(this, EventArgs.Empty);
        }

        // Methods to update UI elements
        public void UpdateScore(int score)
        {
            lblScore.Text = $"Score: {score}";
        }

        public void UpdateTimer(string timeLeft)
        {
            lblTimer.Text = $"Time Left: {timeLeft}";
        }

        public void UpdateTimePeriod(string name, string description)
        {
            lblTimePeriod.Text = name;
            lblDescription.Text = description;
        }

        public void UpdateQuestion(string question)
        {
            lblQuestion.Text = question;
        }

        public string GetAnswer()
        {
            return txtAnswer.Text;
        }

        public void ShowFeedback(string feedback)
        {
            lblFeedback.Text = feedback;
        }

        public void ClearAnswer()
        {
            txtAnswer.Text = "";
        }

        public void EnableNextButton(bool enable)
        {
            btnNext.Enabled = enable;
        }
    }
}
