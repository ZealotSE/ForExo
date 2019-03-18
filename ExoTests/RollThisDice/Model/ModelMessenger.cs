using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class ModelMessenger : IOneSidedContact
    {
        public event EventHandler MessageInvoker;

        public void ReceiveMessage(object sender, System.EventArgs e)
        {
            //Console.WriteLine(this + " recieved message \"" + e.ToString()+" from "+sender.ToString());
        }

        public void SendMessage(System.EventArgs a)
        {
            MessageInvoker.Invoke(this, a);
        }
    }
}