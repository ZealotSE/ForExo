namespace RollThisDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();

            while (true)
            {
                newGame.InitNewGame();
                newGame.Start();
                newGame.SummarizeResult();
            }
        }
    }
}
