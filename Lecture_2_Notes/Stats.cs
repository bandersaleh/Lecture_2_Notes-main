using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Notes
{
    public class Stats
    {
        int _caloriesBurned;
        int _daysWorkedout;

        public Stats()
        {
            _caloriesBurned = 0;
            _daysWorkedout = 0;
        }

        public int CaloriesBurned { get => _caloriesBurned; set => _caloriesBurned = value; }
        public int DaysWorkedout { get => _daysWorkedout; set => _daysWorkedout = value; }

        public void IncreaseDays()
        {
            _daysWorkedout++;
        }



    } // class

} // namespace
