using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class ControllerMessenger : ITwoSidedContact
    {
        public event EventHandler LeftMessageInvoker;
        public event EventHandler RightMessageInvoker;               

        public void ReceiveMessageRight(object sender, EventArgs e)
        {
            Console.WriteLine(this + " recieved message \"" + e.ToString() + " from " + sender.ToString());
        }

        public void ReceiveMessageLeft(object sender, EventArgs e)
        {
            Console.WriteLine(this + " recieved message \"" + e.ToString() + " from " + sender.ToString());
        }

        public void SendMessageLeft(string message)
        {
            LeftMessageInvoker.Invoke(this, new ThresholdReachedEventArgs(message));
        }

        public void SendMessageRight(string message)
        {
            RightMessageInvoker.Invoke(this, new ThresholdReachedEventArgs(message));
        }
    }

}