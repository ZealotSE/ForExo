using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class GameSettings
    {
        public int RoundsInMatch { get; private set; }
        public int TurnsInRound { get; private set; }
        public int PlayersCount { get; private set; }
        public int DicesCount { get; private set; }
        public bool WritePlayerMoves { get; private set; }

        public GameSettings()
        {
            RoundsInMatch = 5;
            TurnsInRound = 10;
            PlayersCount = 2;
            DicesCount = 2;
            WritePlayerMoves = false;
        }

        public void SetRounds(int count)
        {
            if (count >= 4 && count <= 8)
                RoundsInMatch = count;
        }

        public void SetTurns(int count)
        {
            if (count >= 8 && count <= 12)
                TurnsInRound = count;
        }

        public void AddPlayer()
        {
            if (PlayersCount < 4)
                PlayersCount++;
        }

        public void SubtractPlayer()
        {
            if (PlayersCount > 2)
                PlayersCount--;
        }


        public void SetDices(int count)
        {
            if (count >= 2 && count <= 4)
                DicesCount = count;
        }

        public void DrawResult(bool draw)
        {
            WritePlayerMoves = draw;
        }
    }


}
