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

        public void ReceiveMessage(object sender, System.EventArgs e)
        {            
            Console.InterpretMessage(e as EventArgs);
        }
        
        public void SendMessage(System.EventArgs e)
        {
            MessageInvoker.Invoke(this, e);
        } 
    }
}