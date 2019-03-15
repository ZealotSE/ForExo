using System;

namespace RollThisDice
{
    class Dice
    {
        private static Random rand = new Random();
        private int[] PossibleValues;

        public Dice(string type="k6")
        {
            PossibleValues = DiceType(type);
        }

        private int[] DiceType(string type)
        {
            switch (type)
            {
                case "k4":
                    return new int[] { 1, 2, 3, 4 };
                case "k8":
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                case "k12":
                    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                case "k6":
                default:
                    return new int[] { 1, 2, 3, 4, 5, 6 };
            }
        }

        public int Roll()
        {
            return PossibleValues[rand.Next(0, PossibleValues.Length)];
        }
    }
}
