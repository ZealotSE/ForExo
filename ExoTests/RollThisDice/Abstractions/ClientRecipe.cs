using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice.Abstract
{
    abstract class ClientRecipe
    {
        protected abstract ControllerRecipe Controller { get;  }
        protected abstract ModelRecipe Model { get; }
        protected abstract ConsoleRecipe Console { get; }

        public abstract void Init();

        public abstract void Run();

        public abstract void Exit();
        
        protected abstract void Bind(IOneSidedContact ModelMessenger, ITwoSidedContact ControllerMessenger, IOneSidedContact ConsoleMessenger);
    }
}
