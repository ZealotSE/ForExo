using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class GameState
    {
        public bool isGameInProgress { get; private set; }
        public int CurrentRound { get; private set; }
        public int CurrentTurn { get; private set; }
        public int CurrentPlayerIndex { get; private set; }
        
        public void Reset()
        {
            isGameInProgress = false;
            CurrentRound = 1;
            CurrentTurn = 1;
            CurrentPlayerIndex = 0;
        }

        public void Update(bool running,int round, int turn, int player)
        {
            isGameInProgress = running;
            CurrentRound = round;
            CurrentTurn = turn;
            CurrentPlayerIndex = player;
        }
    }
}
