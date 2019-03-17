using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class DiceController : GameController
    {
        public override ITwoSidedContact Messenger { get; }
        
        public DiceController()
        {
            Messenger = new ControllerMessenger();
        }        
    }
}
