using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Abstract
{
    abstract class GameClient
    {

        protected GameConsole Console;
        protected GameState State;
        protected GameController Controller;
        public abstract void Run();

    }
}
