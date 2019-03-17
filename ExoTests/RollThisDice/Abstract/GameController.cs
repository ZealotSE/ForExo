namespace RollThisDice.Abstract
{
    abstract class GameController
    {
        public abstract ITwoSidedContact Messenger {  get; }
        protected GameLogic Logic { get; private set; }
    }
}
