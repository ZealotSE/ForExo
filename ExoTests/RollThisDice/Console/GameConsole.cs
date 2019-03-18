using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    public enum AvaibleWindows { Mainmenu, Settings, Gameplay, History };
    internal class GameConsole : ConsoleRecipe
    {        
        public AvaibleWindows ActualWindow;         
        public override IOneSidedContact Messenger { get; }
        public Windows Window;
        public Actions User;
        
        public GameConsole()
        {
            Messenger = new ConsoleMessenger(this);
            Window = new Windows();
            User = new Actions();
        }

        public void InterpretMessage(EventArgs e)
        {
            switch (e.command)
            {
                case "SHOW_MAINMENU":
                    ActualWindow = AvaibleWindows.Mainmenu;
                    break;
                case "SHOW_SETTINGS":
                    ActualWindow = AvaibleWindows.Settings;
                    break;
                case "START_ROUND":
                case "END_ROUND":
                case "PLAYER_MOVE":
                case "NEXT_PLAYER_MOVE":
                    ActualWindow = AvaibleWindows.Gameplay;
                    break;
                case "SHOW_HISTORY":
                    ActualWindow = AvaibleWindows.History;
                    break;
                case "RELOAD":
                    break;
            }

            Window.Display(e, this);
        }
    }
}