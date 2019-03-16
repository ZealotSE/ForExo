using System;

namespace RollThisDice
{
    interface IReciever
    {
        void ReceiveEvent(object sender, EventArgs e);
    }
}
