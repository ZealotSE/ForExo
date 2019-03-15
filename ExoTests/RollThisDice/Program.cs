using System;

namespace RollThisDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Game NowaGra = new Game();
            NowaGra.Run();

            Console.ReadKey();
        }
    }
}
