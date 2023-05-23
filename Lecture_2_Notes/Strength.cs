using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Notes
{
    public class Strength : Workout
    {
        //      	- Weight
        //- Reps
        float _weight;
        int _rep;

        public float Weight { get => _weight; set => _weight = value; }
        public int Rep { get => _rep; set => _rep = value; }


        // Set Weight
        public void SetWeight(float weight)
        {
            _weight = weight;
        }
  //  IncreaseWeight
        public void IncreaseWeight()
        {
            _weight += 5.0f;

        }

        //  IncraseReps
        public void IncreaseReps()
        {
            _rep++;
        }


    }
}
