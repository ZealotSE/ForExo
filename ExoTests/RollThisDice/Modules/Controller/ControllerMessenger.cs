using System;

namespace RollThisDice
{
    internal class ControllerMessenger : IDuplexInvoker, IDuplexReciever
    {
        public event EventHandler StateEventInvoker;
        public event EventHandler ConsoleEventInvoker;

        public void ContactState()
        {
            StateEventInvoker.Invoke(this, new ThresholdReachedEventArgs());
        }

        public void ContactConsole()
        {
            ConsoleEventInvoker.Invoke(this, new ThresholdReachedEventArgs());
        }

        public void ReceiveConsoleEvent(object sender, EventArgs e)
        {
            Console.WriteLine(ToString() + " recieved event from " + sender.ToString());
        }

        public void ReceiveStateEvent(object sender, EventArgs e)
        {
            Console.WriteLine(ToString() + " recieved event from " + sender.ToString());
        }
    }

}