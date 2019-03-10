using System;

namespace RollThisDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Start();

            Console.WriteLine("Type hist to write game history");
            var type = Console.ReadLine();
            if (type.Equals("hist"))
            {
                newGame.WriteHistory();
                Console.ReadKey();
            }
        }
    }
}
