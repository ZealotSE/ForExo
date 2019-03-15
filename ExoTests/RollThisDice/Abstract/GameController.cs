using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Abstract
{
    abstract class GameController
    {
        public Informator Informator { get; protected set; }
        public abstract void RUN();
    }
}
