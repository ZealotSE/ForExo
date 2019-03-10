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
                throw new ArgumentException("Invalid barcode type argument");
            }
            targetLength = type == 1 ? 8 : 13;
            //check if string contains any characters
            if (!IsDigitsOnly(newCode.ToString()))
            {
                throw new ArgumentException("String doesnt contains digits only");
            }
            //check if barcode is shortened by first 0 - add it
            if (newCode.Length != targetLength)
            {
                if (newCode[0] == '0')
                    newCode.Insert(0, '0');
            }
            //check if barcode has valid length
            if (newCode.Length != targetLength && newCode.Length != targetLength + 2)
            {
                throw new ArgumentException("Invalid barcode length");
            }
            //barcode has add-on - remove it
            else if (newCode.Length == targetLength + 2)
            {
                newCode.Remove(targetLength, 2);
            }
            //calculate and compare checksum 
            if (CalculateChecksum(newCode.ToString()) != Int32.Parse(newCode[newCode.Length - 1].ToString()))
            {
                throw new ArgumentException("Invalid checksum");
            }

            //barcode is valid 
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
            var checksum = code[code.Length-1];
            var result = 0;
            for (int i = 0; i < code.Length-1; ++i)
            {
                Int32.TryParse(code[i].ToString(), out int number);
                if (i % 2 == 0)
                    result += number * 3;
                else
                    result += number;
            }
            return 10 - result % 10;
        }
    }
}
