using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Actions
    {
        public void NextAction(EventArgs e, GameConsole Console)
        {
            string result="";

            switch (Console.ActualWindow)
            {
                case AvaibleWindows.Mainmenu:
                    result=MainMenuWindowAction();
                    break;
                case AvaibleWindows.Settings:
                    result=SettingsWindowAction();
                    break;
                case AvaibleWindows.History:
                    result=HistoryWindowAction();
                    break;
                case AvaibleWindows.Gameplay:
                    result=GameplayWindowAction();
                    break;
            }
            Console.Messenger.SendMessage(new EventArgs(result));
        }

        private string MainMenuWindowAction()
        {
            string e;
            switch (System.Console.ReadKey().KeyChar)
            {
                case '1':
                    e = ("START_NEW_GAME");
                    break;
                case '2':
                    e = ("SHOW_SETTINGS");
                    break;
                case '3':
                    e = ("SHOW_HISTORY");
                    break;
                case '0':
                    e = ("QUIT_GAME");
                    break;
                default:
                    e = "RELOAD";
                    break;
            }
            return e;
        }

        private string SettingsWindowAction()
        {
            string e;
            switch (System.Console.ReadKey().KeyChar)
            {
                case '0':
                    e = ("SHOW_MAINMENU");
                    break;
                default:
                    e = "RELOAD";
                    break;
            }
            return e;
        }

        private string GameplayWindowAction()
        {
            string e;
            switch (System.Console.ReadKey().KeyChar)
            {
                case '0':
                    e = ("SHOW_MAINMENU");
                    break;
                default:
                    e = "RELOAD";
                    break;
            }
            return e;
        }

        private string HistoryWindowAction()
        {
            string e;
            switch (System.Console.ReadKey().KeyChar)
            {
                case '0':
                    e = ("SHOW_MAINMENU");
                    break;
                default:
                    e = "RELOAD";
                    break;
            }
            return e;
        }
    }
    }
