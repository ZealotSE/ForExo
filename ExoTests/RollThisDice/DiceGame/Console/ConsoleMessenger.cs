using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class ConsoleMessenger : IOneSidedContact
    {
        public event EventHandler MessageInvoker;
        
        public void ReceiveMessage(object sender, EventArgs e)
        {
            Console.WriteLine(this + " recieved message \"" + e.ToString() + " from " + sender.ToString());
        }
        
        public void SendMessage(string a)
        {
            MessageInvoker.Invoke(this, new ThresholdReachedEventArgs(a));
        }        
    }
}