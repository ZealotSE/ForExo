using System;

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
            Console.WriteLine("Created player");
        }

        public void AddPoints(int points)
        {
            Points += points;
        }

        public int RollDice(Dice dice)
        {
            dice.Roll();
            return dice.Value;
        }
    }
}
