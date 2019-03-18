using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Settings
    {
        public int playersNumber;
        public int dicesNumber;
        public int roundsNumber;
        public int turnsNumber;

        public Settings()
        {
            playersNumber = 2;
            dicesNumber = 2;
            roundsNumber = 5;
            turnsNumber = 10;
        }
    }
}
