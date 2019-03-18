using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    class GameConsole : ConsoleRecipe
    {
        enum AvaibleWindows { Mainmenu, Settings, Gameplay, Default }
        AvaibleWindows ToDisplay;
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
                    ToDisplay = AvaibleWindows.Mainmenu;
                    break;
                case "SETTINGS":
                    ToDisplay = AvaibleWindows.Settings;
                    break;
                case "DEFAULT":
                    ToDisplay = AvaibleWindows.Default;
                    break;
                default:
                    ToDisplay = AvaibleWindows.Default;
                    break;
            }
            Display();
        }

        protected override void Display()
        {
            switch (ToDisplay)
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
                    break;
            }
            ChooseAction();
        }

        private void ChooseAction()
        {
            var key = Console.ReadKey().KeyChar;
            Messenger.SendMessage(key.ToString());
        }
    }
}