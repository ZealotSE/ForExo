using System;

namespace RollThisDice.Abstract
{
    interface ITwoSidedContact
    {
        event EventHandler LeftMessageInvoker;
        event EventHandler RightMessageInvoker;
        
        void ReceiveMessageLeft(object sender, EventArgs e);
        void ReceiveMessageRight(object sender, EventArgs e);
        void SendMessageLeft(string a);
        void SendMessageRight(string a);
    }
}
