using System;   

namespace RollThisDice
{
    class DiceController : GameController
    {
        public ControllerMessenger Messenger { get;  set; }

        public DiceController()
        {
            Messenger = new ControllerMessenger();
        }
    }
}
