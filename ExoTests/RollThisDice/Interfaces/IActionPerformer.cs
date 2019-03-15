using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Interfaces
{
    interface IActionPerformer
    {
        void SelectAction(object sender, EventArgs e);        
    }
}
