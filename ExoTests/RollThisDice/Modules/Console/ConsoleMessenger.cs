using System;

namespace RollThisDice
{
    internal class ConsoleMessenger : IInvoker, IReciever
    {
        public event EventHandler EventInvoker;
        
        public void ReceiveEvent(object sender, EventArgs e)
        {
            Console.WriteLine(ToString() + " recieved event from " + sender.ToString());
        }
        public void ContactController()
        {
            EventInvoker.Invoke(this, new ThresholdReachedEventArgs());
        }

    }
}