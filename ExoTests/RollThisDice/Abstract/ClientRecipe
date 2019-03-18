namespace RollThisDice.Abstract
{
    abstract class GameClient
    {
        protected abstract GameModel Model {get;}
        protected abstract GameConsole Console { get; }
        protected abstract GameController Controller { get; }
        
        protected abstract void Bind(IOneSidedContact ControllerMessenger, ITwoSidedContact ModelMessenger, IOneSidedContact ConsoleMessenger);

        public abstract void Run();
    }
}
