using System;

namespace RollThisDice
{
    class DiceGameState : GameState
    {
        public StateMessenger Messenger { get;  set; }

        public DiceGameState()
        {
            Messenger = new StateMessenger();
        }
    }
}


//public bool IsGameRunning { get; private set; }
//public int CurrentRound { get; private set; }
//public int CurrentTurn { get; private set; }
//public int CurrentPlayerIndex { get; private set; }

//public void SetInitialValues()
//{
//    if (!IsGameRunning)
//    {
//        CurrentRound = 1;
//        CurrentTurn = 1;
//        CurrentPlayerIndex = 0;
//    }
//}

//public void Update(int round, int turn, int player)
//{
//    CurrentRound = round;
//    CurrentTurn = turn;
//    CurrentPlayerIndex = player;
//}

//public void GameStops()
//{
//    IsGameRunning = false;
//}

//public void GameStarts()
//{
//    IsGameRunning = true;
//}
