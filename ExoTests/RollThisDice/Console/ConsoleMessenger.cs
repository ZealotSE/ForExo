using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class ConsoleMessenger : IOneSidedContact
    {
        private GameConsole Console;        
        public event EventHandler MessageInvoker;
        
        public ConsoleMessenger(GameConsole Console)
        {
            this.Console = Console;
        }

        public void ReceiveMessage(object sender, EventArgs message)
        {            
            Console.MessageArrived(message.ToString());
        }
        
        public void SendMessage(string message)
        {
            MessageInvoker.Invoke(this, new ThresholdReachedEventArgs(message));
        } 
    }
}