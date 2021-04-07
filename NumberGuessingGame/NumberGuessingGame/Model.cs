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
        public int TriesLeft { get; set; }
        public bool HasSound { get; set; }
        public int GameId { get; set; }

        public Model(bool hasSound, int gameId)
        {
            HasSound = hasSound;
            TriesLeft = 5;
            GameId = gameId;
        }
    }
}
