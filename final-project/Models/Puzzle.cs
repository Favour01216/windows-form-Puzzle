using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Models
{
    public class Puzzle
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsSolved { get; set; }
        public string Narrative { get; set; }
        public bool HasAnomaly { get; set; }
        public string AnomalyDescription { get; set; }

        public Puzzle(string question, string answer, string narrative = "", bool hasAnomaly = false, string anomalyDescription = "")
        {
            Question = question;
            Answer = answer;
            IsSolved = false;
            Narrative = narrative;
            HasAnomaly = hasAnomaly;
            AnomalyDescription = anomalyDescription;
        }

        public bool CheckAnswer(string userAnswer)
        {
            if (userAnswer.Trim().ToLower() == Answer.ToLower())
            {
                IsSolved = true;
                return true;
            }
            return false;
        }
    }
}
