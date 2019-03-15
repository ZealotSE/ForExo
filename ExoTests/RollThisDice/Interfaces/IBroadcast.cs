using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Interfaces
{
    interface IBroadcast
    {
        event EventHandler OnStateChanged;
        event EventHandler OnActionPerformed;
    }
}
