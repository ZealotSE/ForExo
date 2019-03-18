using System;

namespace RollThisDice.Abstract
{
    interface ITwoSidedContact
    {
        event EventHandler LeftMessageInvoker;
        event EventHandler RightMessageInvoker;
        
        void ReceiveMessageLeft(object sender, System.EventArgs e);
        void ReceiveMessageRight(object sender, System.EventArgs e);
        void SendMessageLeft(System.EventArgs a);
        void SendMessageRight(System.EventArgs a);
    }
}
