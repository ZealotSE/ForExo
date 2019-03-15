using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class DiceController : Abstract.GameController
    {        
        public DiceController()
        {
            Informator = new Informator();
        }

        public override void RUN()
        {
            Informator.callme();
        }
    }
}
