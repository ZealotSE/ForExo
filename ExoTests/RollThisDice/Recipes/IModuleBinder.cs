namespace RollThisDice
{
    interface IModuleBinder
    {
        void BindEvents(ControllerMessenger Controller, ConsoleMessenger Console, StateMessenger State);
    }
}
