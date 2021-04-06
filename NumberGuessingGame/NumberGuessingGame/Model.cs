using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Model
    {
        public int MaxNumber { get; set; }
        public int CorrectNumber { get; set; }
        public bool HasSound { get; set; }


        public Model(int maxNumber, int correctNumber, bool hasSound)
        {
            MaxNumber = maxNumber;
            CorrectNumber = correctNumber;
            HasSound = hasSound;
        }
    }
}
