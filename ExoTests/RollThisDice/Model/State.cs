using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class State
    {
        public int currentPlayer;
        public int currentRound;
        public int currentTurn;

        public State()
        {
            currentPlayer = 1;
            currentRound = 1;
            currentTurn = 1;
        }
    }
}
