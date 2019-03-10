using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Dice
    {
        private static Random rand = new Random();
        private int[] PossibleValues;
        public int Value { get; private set; }

        public Dice()
        {
            PossibleValues = new int[] { 1, 2, 3, 4, 5, 6 };
            Value = rand.Next(1, 7);
            Console.WriteLine("Created dice");
        }       

        public void Roll()
        {            
            Value = PossibleValues[rand.Next(0, 6)];            
        }
    }
}
