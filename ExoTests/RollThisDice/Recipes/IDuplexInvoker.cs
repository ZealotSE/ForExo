using System;

namespace RollThisDice
{
    interface IDuplexInvoker
    {
        event EventHandler StateEventInvoker;
        event EventHandler ConsoleEventInvoker;
    }
}
