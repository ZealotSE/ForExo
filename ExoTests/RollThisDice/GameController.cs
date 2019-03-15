using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class GameController
    {
        private GameSettings Settings;
        private GameState State;
        private GameConsole Console;
        private List<Player> Players;
        private List<Dice> Dices;

        public GameController(GameSettings Settings, GameState State)
        {
            this.Settings = Settings;
            this.State = State;
            Players = new List<Player>();
            Dices = new List<Dice>();
        }
        
        public void SetConsole(GameConsole Console)
        {
            this.Console = Console;
        }

        internal void StartNewGame()
        {
            InitVariables();
        }

        private void InitVariables()
        {
            Player.Prepare();
            Players.Clear();

            for (int i = 0; i < Settings.PlayersCount;++i)
                Players.Add(new Player());
            for (int i = 0; i < Settings.DicesCount; ++i)
                Dices.Add(new Dice());
        }
    }
}
