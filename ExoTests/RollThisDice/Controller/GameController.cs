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

        public override void SetToken(ClientRecipe Client)
        {
            this.Client = (DiceGameClient)Client;
        }

        public override bool IsTokenSet()
        {
            return Client == null ? false : true;
            
        }

        public override void LaunchGame()
        {
            Messenger.SendMessageRight("MAINMENU");
        }

        public void MessageArrived(string arguments)
        {

            switch (arguments)
            {
                case "1":
                    Messenger.SendMessageRight("MAINMENU");
                    break;
                case "2":
                    Messenger.SendMessageRight("SETTINGS");
                    break;
                case "0":
                    Client.Exit();
                    break;
                default:
                    Messenger.SendMessageRight("DEFAULT");
                    break;
            }
        }
    }
}
