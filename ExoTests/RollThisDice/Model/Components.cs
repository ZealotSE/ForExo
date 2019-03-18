using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Components
    {
        public List<Dice> Dices;
        public List<Player> Players;
        public string history;

        public Components()
        {
            Dices = new List<Dice>();
            Players = new List<Player>();
            history = "";
        }
    }
}
