using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class GameController : ControllerRecipe
    {
        private DiceGameClient Client;
        public override ITwoSidedContact Messenger { get; }
        
        public GameController()
        {
            Messenger = new ControllerMessenger(this);
        } 

        public override void LaunchGame()
        {
            Messenger.SendMessageRight(new EventArgs("SHOW_MAINMENU"));
        }

        public void ReadMessage(EventArgs e)
        {
            switch (e.command)
            {
                case "SHOW_MAINMENU":
                    Messenger.SendMessageRight(new EventArgs("SHOW_MAINMENU"));
                    break;
                case "START_NEW_GAME":
                    Messenger.SendMessageRight(new EventArgs("START_ROUND"));
                    break;
                case "SHOW_SETTINGS":
                    Messenger.SendMessageRight(new EventArgs("SHOW_SETTINGS"));
                    break;
                case "RELOAD":
                    Messenger.SendMessageRight(new EventArgs("RELOAD"));
                    break;
                case "SHOW_HISTORY":
                    Messenger.SendMessageRight(new EventArgs("SHOW_HISTORY"));
                    break;
                case "QUIT_GAME":
                    Client.Exit();
                    break;
            }
        }

        public override void SetToken(ClientRecipe Client)
        {
            this.Client = (DiceGameClient)Client;
        }

        public override bool IsTokenSet()
        {
            return Client == null ? false : true;

        }
    }
}
