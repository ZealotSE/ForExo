using System;

namespace RollThisDice
{
    internal class StateMessenger : IInvoker, IReciever
    {
        public event EventHandler EventInvoker;        

        public void ContactController()
        {
            EventInvoker.Invoke(this,new ThresholdReachedEventArgs());
        }

        public void ReceiveEvent(object sender, EventArgs e)
        {
            Console.WriteLine(ToString() + " recieved event from " + sender.ToString());
        }
        
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}