using System;

namespace RollThisDice.Abstract
{
    interface IOneSidedContact
    {
        event EventHandler MessageInvoker;
        
        void ReceiveMessage(object sender, EventArgs e);
        void SendMessage(string a);
    }
}
