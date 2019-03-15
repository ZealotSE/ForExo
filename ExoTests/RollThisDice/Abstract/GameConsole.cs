using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Abstract
{
    abstract class GameConsole
    {
        public ActionPerformer performer { get; protected set; }
    }
}
