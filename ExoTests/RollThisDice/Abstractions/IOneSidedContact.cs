using System;

namespace RollThisDice.Abstract
{
    interface IOneSidedContact
    {
        event EventHandler MessageInvoker;
        
        void ReceiveMessage(object sender, System.EventArgs e);
        void SendMessage(System.EventArgs a);
    }
}
