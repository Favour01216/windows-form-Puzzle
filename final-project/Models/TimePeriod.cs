using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Models
{
    public class TimePeriod
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Puzzle> Puzzles { get; set; }

        public TimePeriod(string name, string description)
        {
            Name = name;
            Description = description;
            Puzzles = new List<Puzzle>();
        }

        public void AddPuzzle(Puzzle puzzle)
        {
            Puzzles.Add(puzzle);
        }
    }
}
