using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    internal class ControllerMessenger : ITwoSidedContact
    {
        private GameController Controller;
        public event EventHandler LeftMessageInvoker;
        public event EventHandler RightMessageInvoker;               

        public ControllerMessenger(GameController Controller)
        {
            this.Controller = Controller;
        }

        public void ReceiveMessageRight(object sender, System.EventArgs e)
        {
            Controller.ReadMessage(e as EventArgs);
        }

        public void ReceiveMessageLeft(object sender, System.EventArgs e)
        {
            //Console.WriteLine(this + " recieved message \"" + e.ToString() + " from " + sender.ToString());
        }

        public void SendMessageLeft(System.EventArgs e)
        {
            LeftMessageInvoker.Invoke(this, e);
        }

        public void SendMessageRight(System.EventArgs e)
        {
            RightMessageInvoker.Invoke(this, e);
        }
    }

}