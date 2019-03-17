using System;

namespace RollThisDice
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceGameClient NewGame = new DiceGameClient();           
            NewGame.Run();

            Console.ReadKey();
        }
    }
}
