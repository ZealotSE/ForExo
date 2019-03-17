using System;
using RollThisDice.Abstract;

namespace RollThisDice
{
    class DiceConsole : GameConsole
    {
        public override IOneSidedContact Messenger { get; }
        
        public DiceConsole()
        {
            Messenger = new ConsoleMessenger();            
        }        
    }    
}


//public void ShowMainMenu()
//{
//    Console.Clear();
//    Console.WriteLine(
//        "\n    Roll this dice!\n\n" +
//        "  1 -> Start new game\n" +
//        "  2 -> Show previous game\n" +
//        "  3 -> Settings\n" +
//        "  0 -> Exit game\n");
//    switch (Console.ReadKey().KeyChar)
//    {
//        case '1':
//            break;
//        case '2':
//            break;
//        case '3':
//            break;
//        case '0':
//            break;
//        default:
//            break;
//    }
//}
//private void ShowSettingsMenu()
//{
//    Console.Clear();
//    Console.WriteLine(
//        $"\n    Settings\n\n");
//}