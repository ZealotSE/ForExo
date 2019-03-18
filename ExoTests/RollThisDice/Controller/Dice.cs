using System;

namespace RollThisDice
{
    class Dice
    {
        private static Random rand = new Random();
        protected int[] PossibleValues { private get; set; }
        public enum AvaibleTypes { k4 = 4, k6 = 6, k8 = 8, k12 = 12 }

        public Dice(string diceType = "k6")
        {
            SetValues(diceType);
        }

        private void SetValues(string diceType)
        {
            switch (diceType)
            {
                case "k4":
                    PossibleValues = new int[] { 1, 2, 3, 4 };
                    break;
                case "k8":
                    PossibleValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                    break;
                case "k12":
                    PossibleValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    break;
                case "k6":
                default:
                    PossibleValues = new int[] { 1, 2, 3, 4, 5, 6 };
                    break;
            }
        }

        public int Roll()
        {
            return PossibleValues[rand.Next(0, PossibleValues.Length)];
        }
    }
}
