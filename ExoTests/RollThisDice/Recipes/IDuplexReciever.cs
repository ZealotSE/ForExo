using System;

namespace RollThisDice
{
    interface IDuplexReciever
    {
        void ReceiveStateEvent(object sender, EventArgs e);
        void ReceiveConsoleEvent(object sender, EventArgs e);
    }
}
