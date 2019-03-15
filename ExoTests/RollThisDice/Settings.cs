using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Settings
    {
        public int RoundsInMatch { get; private set; }
        public int TurnsInRound { get; private set; }
        public int PlayersCount { get; private set; }
        public int DicesCount { get; private set; }
        public bool WriteInConsole { get; private set; }

        public Settings()
        {
            RoundsInMatch = 5;
            TurnsInRound = 10;
            PlayersCount = 2;
            DicesCount = 2;
            WriteInConsole = false;
        }
        
        public void SetRounds(int count)
        {
            if (count >= 4 || count <= 8)
                RoundsInMatch = count;
        }

        public void SetTurns(int count)
        {
            if (count >= 8 || count <= 12)
                TurnsInRound = count;
        }

        public void SetPlayers(int count)
        {
            if (count >= 2 || count <= 4)
                PlayersCount = count;
        }

        public void SetDices(int count)
        {
            if (count >= 2 || count <= 4)
                DicesCount = count;
        }

        public void DrawResult(bool draw)
        {
            WriteInConsole = draw;
        }
    }


}
