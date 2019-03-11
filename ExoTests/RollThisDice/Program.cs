namespace RollThisDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.InitNewGame();
            newGame.Start();
            newGame.SummarizeResult();
        }
    }
}
