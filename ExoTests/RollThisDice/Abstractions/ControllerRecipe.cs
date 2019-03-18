namespace RollThisDice.Abstract
{
    abstract class ControllerRecipe
    {
        public abstract ITwoSidedContact Messenger {  get; }
        public abstract void SetToken(ClientRecipe token);
        public abstract bool IsTokenSet();
        public abstract void LaunchGame();
        protected GameLogic Logic { get; private set; }
    }
}
