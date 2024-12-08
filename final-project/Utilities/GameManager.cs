using final_project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace final_project.Utilities
{
    public class GameManager
    {
        public Player Player { get; set; }
        public List<TimePeriod> TimePeriods { get; set; }
        public int CurrentPeriodIndex { get; set; }

        private string saveFilePath = "savegame.json";

        public GameManager(string playerName)
        {
            Player = new Player(playerName);
            TimePeriods = new List<TimePeriod>();
            CurrentPeriodIndex = 0;
            InitializeTimePeriods();
        }

        private void InitializeTimePeriods()
        {
            // Example: Renaissance Period
            TimePeriod renaissance = new TimePeriod("Renaissance", "A period of great cultural change and achievement.");
            renaissance.AddPuzzle(new Puzzle("Who painted the Mona Lisa?", "Leonardo da Vinci", "As you solve this puzzle, you notice the vibrant art of the era."));
            renaissance.AddPuzzle(new Puzzle("What invention greatly impacted navigation during the Renaissance?", "Compass", "The compass revolutionized exploration and trade."));
            renaissance.AddPuzzle(new Puzzle("Which city is considered the cradle of the Renaissance?", "Florence", "Florence thrived with artists and thinkers."));

            // Example: Medieval Era
            TimePeriod medieval = new TimePeriod("Medieval Era", "A period characterized by feudalism and knights.");
            medieval.AddPuzzle(new Puzzle("What was the primary weapon of knights?", "Sword", "The sword was a symbol of knighthood and valor."));
            medieval.AddPuzzle(new Puzzle("What structure was central to medieval towns?", "Castle", "Castles provided defense and were centers of power."));
            medieval.AddPuzzle(new Puzzle("What document limited the king's power in England?", "Magna Carta", "The Magna Carta was a cornerstone of modern democracy."));

            // Add more time periods and puzzles as needed
            TimePeriods.Add(renaissance);
            TimePeriods.Add(medieval);

            // Shuffle puzzles in each time period
            foreach (var period in TimePeriods)
            {
                period.Puzzles = period.Puzzles.OrderBy(p => Guid.NewGuid()).ToList();
            }
        }

        public TimePeriod GetCurrentTimePeriod()
        {
            if (CurrentPeriodIndex < TimePeriods.Count)
                return TimePeriods[CurrentPeriodIndex];
            return null;
        }

        public void AdvanceToNextPeriod()
        {
            CurrentPeriodIndex++;
        }

        public bool IsGameOver()
        {
            return CurrentPeriodIndex >= TimePeriods.Count;
        }

        public void SaveGame()
        {
            var saveData = new SaveData
            {
                PlayerName = Player.Name,
                PlayerScore = Player.Score,
                CurrentPeriodIndex = CurrentPeriodIndex,
                TimePeriods = TimePeriods
            };

            string json = JsonConvert.SerializeObject(saveData, Formatting.Indented);
            File.WriteAllText(saveFilePath, json);
        }

        public void LoadGame()
        {
            if (File.Exists(saveFilePath))
            {
                string json = File.ReadAllText(saveFilePath);
                var saveData = JsonConvert.DeserializeObject<SaveData>(json);

                Player = new Player(saveData.PlayerName)
                {
                    Score = saveData.PlayerScore
                };
                CurrentPeriodIndex = saveData.CurrentPeriodIndex;
                TimePeriods = saveData.TimePeriods;
            }
        }
    }
}
