using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class GameConsole
    {
        private GameSettings Settings;
        private GameState State;
        private GameController Controller;

        public GameConsole(GameSettings Settings, GameState State)
        {
            this.Settings = Settings;
            this.State = State;
        }

        public void SetController(GameController Controller)
        {
            this.Controller = Controller;
        }

        public void ShowMainMenu()
        {
            //Console.Clear();
            Console.WriteLine("\n       Roll this dice!\n\n\n  1 - New game\n  2 - Settings\n  3 - Exit\n");
            switch(Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine("New game");
                    Controller.StartNewGame();
                    break;
                case '2':
                    Console.WriteLine("Setting");
                    ShowSettingsMenu();
                    break;
                case '3':
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.Clear();
                    ShowMainMenu();
                    break;
            }
            ShowMainMenu();
        }

        private void ShowSettingsMenu()
        {
            Console.Clear();
            Console.WriteLine("\n       Settings\n\n\n  Number of players: {0}    ( 1 - more , 2 - less)\n\n  0 - exit ",Settings.PlayersCount);
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Settings.SetPlayers(Settings.PlayersCount + 1);
                    ShowSettingsMenu();
                    break;
                case '2':
                    Settings.SetPlayers(Settings.PlayersCount + -1);
                    ShowSettingsMenu();
                    break;
                case '0':
                    ShowMainMenu();
                    break;
                default:
                    ShowSettingsMenu();
                    break;

            }
        }
    }    
}
