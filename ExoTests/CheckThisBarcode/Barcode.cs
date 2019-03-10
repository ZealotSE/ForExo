using System;
using System.Text;

namespace CheckThisBarcode
{
    static class Barcode
    {
        public static string Check(string code, int type)
        {
            StringBuilder newCode = new StringBuilder(code);
            int targetLength;

            //check second argument
            if (type != 1 && type != 2)
            {
                throw new ArgumentException("Invalid second argument. Values '1' or '2' permitted only.");
            }
            targetLength = type == 1 ? 8 : 13;
            //check if string contains any other chars than digits
            if (!IsDigitsOnly(newCode.ToString()))
            {
                throw new ArgumentException("Invalid first argument. Digits permitted only.");
            }
            //check if barcode is shortened by first 0 - add it if so
            if (newCode.Length != targetLength)
            {
                if (newCode[0] == '0')
                    newCode.Insert(0, '0');
            }
            //check if barcode has valid allowing possible add-on
            if (newCode.Length != targetLength && newCode.Length != targetLength + 2)
            {
                throw new ArgumentException("Invalid barcode length.");
            }
            //remove add-on if code contains it
            else if (newCode.Length == targetLength + 2)
            {
                newCode.Remove(targetLength, 2);
            }
            //calculate correct checksum and compare with last code digit
            if (CalculateChecksum(newCode.ToString()) != Int32.Parse(newCode[newCode.Length - 1].ToString()))
            {
                throw new ArgumentException("Invalid barcode checksum at last code possition.");
            }
            //all conditions met, return correct barcode
            return newCode.ToString();
        }

        private static bool IsDigitsOnly(string code)
        {
            foreach (char character in code)
            {
                if (character < '0' || character > '9')
                    return false;
            }
            return true;
        }

        private static int CalculateChecksum(string code)
        {
            int calculatedResult = 0;
            int tempDigit;
            for (int i = 0; i < code.Length-1; ++i)
            {
                tempDigit = Int32.Parse(code[i].ToString());
                //Console.WriteLine(tempDigit);
                if (i + 1 % 2 == 0) 
                    calculatedResult += tempDigit;      //even
                else                
                    calculatedResult += tempDigit * 3;  //odd
            }
            //Console.WriteLine(calculatedResult % 10);
            return calculatedResult % 10;
        }
    }
}
