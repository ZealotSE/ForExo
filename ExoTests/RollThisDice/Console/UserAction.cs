using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class UserAction
    {
        public GameConsole console;
        public void PressButton(EventArgs e, GameConsole Console)
        {
            console = Console;
            var key = System.Console.ReadKey().KeyChar;
            switch (Console.ActualWindow)
            {
                case AvaibleWindows.Mainmenu:
                    MainMenuAction(e, key);
                    break;
                case AvaibleWindows.Settings:
                    SettingsAction(e, key);
                    break;
                case AvaibleWindows.History:
                    HistoryAction(e, key);
                    break;
                case AvaibleWindows.Gameplay:
                    GameplayAction(e, key);
                    break;
            }
        }

        private void GameplayAction(EventArgs e, char keyInfo)
        {
            switch (keyInfo)
            {
                case '1':
                    e = new EventArgs("SHOW_MAINMENU");
                    break;
                case '2':
                    e = new EventArgs("SHOW_SETTINGS");
                    break;
                case '0':
                    e = new EventArgs("QUIT_GAME");
                    break;
                default:
                    console.Window.Display(e, console);
                    break;
            }
            console.Messenger.SendMessage(e);
        }

        private void HistoryAction(EventArgs e, char keyInfo)
        {
            throw new NotImplementedException();
        }

        private void SettingsAction(EventArgs e, char keyInfo)
        {
            switch (keyInfo)
            {
                case '1':
                    e = new EventArgs("START_NEW_GAME");
                    break;
                case '2':
                    e = new EventArgs("SHOW_SETTINGS");
                    break;
                case '0':
                    e = new EventArgs("QUIT_GAME");
                    break;
                default:
                    console.Window.Display(e, console);
                    break;
            }
            console.Messenger.SendMessage(e);
        }

        private void MainMenuAction(EventArgs e, char keyInfo)
        {
            switch (keyInfo)
            {
                case '1':
                    e = new EventArgs("START_NEW_GAME");
                    break;
                case '2':
                    e = new EventArgs("SHOW_SETTINGS");
                    break;
                case '0':
                    e = new EventArgs("QUIT_GAME");
                    break;
                default:
                    console.Window.Display(e, console);
                    break;
            }
            console.Messenger.SendMessage(e);
        }
    }
    }
