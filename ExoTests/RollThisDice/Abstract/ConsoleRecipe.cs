namespace RollThisDice.Abstract
{
    abstract class ConsoleRecipe
    {        
        public abstract IOneSidedContact Messenger { get; }        

        protected abstract void Display();
    }
}
