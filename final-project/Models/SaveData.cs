using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.Models
{
    public class SaveData
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int CurrentPeriodIndex { get; set; }
        public List<TimePeriod> TimePeriods { get; set; }
    }
}
