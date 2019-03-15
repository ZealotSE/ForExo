namespace RollThisDice
{
    class Player
    {
        private static readonly string[] Names = { "Pierwszy", "Drugi", "Trzeci", "Czwarty" };
        private static int count;
        public string Name { get; private set; }
        public int Points { get; private set; }

        public Player()
        {
            Name = Names[count];
            Points = 0;
            System.Console.WriteLine("Created {0}th player named {1}",count,Name);
            count++;
        }

        public static void Prepare()
        {
            count = 0;
        }

        public void AddPoints(int points)
        {
            Points += points;
        }
    }
}
