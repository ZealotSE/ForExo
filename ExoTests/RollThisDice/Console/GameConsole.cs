using System;
using RollThisDice.Abstract;

namespace RollThisDice
{    
    class GameConsole : ConsoleRecipe
    {
        enum AvaibleWindows { Mainmenu, Settings, Gameplay, Default };
        AvaibleWindows ActualWindow;         
        public override IOneSidedContact Messenger { get; }
        private Windows Window;
        
        public GameConsole()
        {
            Messenger = new ConsoleMessenger(this);
            Window = new Windows();
        }

        public void MessageArrived(string arguments)
        {
            switch (arguments)
            {
                case "MAINMENU":
                    ActualWindow = AvaibleWindows.Mainmenu;
                    break;
                case "SETTINGS":
                    ActualWindow = AvaibleWindows.Settings;
                    break;
                case "DEFAULT":
                    ActualWindow = AvaibleWindows.Default;
                    break;
                default:
                    ActualWindow = AvaibleWindows.Default;
                    break;
            }
            Display();
        }

        protected override void Display()
        {
            switch (ActualWindow)
            {
                case AvaibleWindows.Mainmenu:
                    Window.MainMenu();
                    break;
                case AvaibleWindows.Settings:
                    Window.Settings();
                    break;
                case AvaibleWindows.Default:
                    Window.Default();
                    break;
                default:
                    Window.Default();
                    break;
            }
            NextAction();
        }

        private void NextAction()
        {
            var key = Console.ReadKey().KeyChar;
            Messenger.SendMessage(key.ToString());
        }
    }
}