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
        public bool IsGameOn { get; private set; }
        public int CurrentRound { get; private set; }
        public int CurrentTurn { get; private set; }
        public int CurrentPlayerIndex { get; private set; }
        
        public GameState()
        {
            IsGameOn = false;
            SetInitialValues();
        }

        public void SetInitialValues()
        {
            if (!IsGameOn)
            {
                CurrentRound = 1;
                CurrentTurn = 1;
                CurrentPlayerIndex = 0;
            }
        }

        public void Update(int round, int turn, int player)
        {
            CurrentRound = round;
            CurrentTurn = turn;
            CurrentPlayerIndex = player;
        }

        public void GameStops()
        {
            IsGameOn = false;
        }

        public void GameStarts()
        {
            IsGameOn = true;
        }
    }
}
