using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Interfaces
{
    interface IModuleBinder
    {
        void BindControllerCalls(IBroadcast ActionProclaimer, IActionPerformer ActionSelector, IVariableData DataValidator);
    }
}
