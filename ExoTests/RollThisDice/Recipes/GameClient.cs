namespace RollThisDice
{
    abstract class GameClient : IModuleBinder
    {
        public abstract void BindEvents(ControllerMessenger Controller, ConsoleMessenger Console, StateMessenger State);
        
        public abstract void Run();
    }
}
