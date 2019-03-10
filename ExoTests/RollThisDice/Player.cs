namespace RollThisDice
{
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name)
        {
            Name = name;
            Points = 0;
        }

        public int RollDice(Dice dice)
        {
            dice.Roll();
            return dice.Value;
        }
    }
}
