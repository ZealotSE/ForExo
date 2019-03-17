namespace RollThisDice
{
    class Player
    {
        private static readonly string[] Names = { "Pierwszy", "Drugi", "Trzeci", "Czwarty" };
        protected static int Count { get; private set; } = 0;
        private string Name { get; }
        public int Points { get; set; }

        public Player()
        {
            Points = 0;
            Name = Names[Count];
            Count++;
        }

        public void ResetPlayers()
        {
            Count = 0;
        }
    }
}
