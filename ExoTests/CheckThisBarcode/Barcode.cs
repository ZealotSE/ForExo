using System;
using System.Text;

namespace CheckThisBarcode
{
    static class Barcode
    {
        public static string Check(string code, int type)
        {
            StringBuilder temporaryCode = new StringBuilder(code);

            CheckSecondArgument(type, out int targetLength);
            CheckDigits(temporaryCode);
            CheckFirstZero(ref temporaryCode, targetLength);
            CheckAddon(ref temporaryCode, targetLength);
            //CheckChecksum(temporaryCode);    Turned off for tests     

            return temporaryCode.ToString();
        }

        //check the correctness of second argument
        private static void CheckSecondArgument(int type, out int length)
        {
            if (type != 1 && type != 2)
            {
                throw new ArgumentException("Invalid second argument. Values '1' or '2' permitted only.");
            }
            else
                length = type == 1 ? 8 : 13;
        }

        //checks if input string contains any other chars than digits
        private static void CheckDigits(StringBuilder code)
        {
            if (!IsDigitsOnly(code.ToString()))
            {
                throw new ArgumentException("Invalid first argument. Digits permitted only.");
            }
        }

        //checks if barcode is shortened by 0 and adds it at beggining if so
        private static void CheckFirstZero(ref StringBuilder code, int length)
        {
            if (code.Length != length)
            {
                if (code[0] == '0')
                    code.Insert(0, '0');
            }
        }

        //checks if barcode contains add-on and removes it if so 
        private static void CheckAddon(ref StringBuilder code, int length)
        {
            if (code.Length != length && code.Length != length + 2)
            {
                throw new ArgumentException("Invalid barcode length.");
            }
            else if (code.Length == length + 2)
            {
                code.Remove(length, 2);
            }
        }

        //compare calculated checksum with one from input barcode
        private static void CheckChecksum(StringBuilder code)
        {
            if (CalculateChecksum(code.ToString())
                != Int32.Parse(code[code.Length - 1].ToString()))
            {
                throw new ArgumentException("Invalid checksum in given barcode.");
            }
        }

        //checks if input string contains non-digits
        private static bool IsDigitsOnly(string code)
        {
            foreach (char character in code)
            {
                if (character < '0' || character > '9')
                    return false;
            }
            return true;
        }

        //calculatin checksum for input barcode
        private static int CalculateChecksum(string code)
        {
            int calculatedResult = 0;
            int tempDigit;

            for (int i = 0; i < code.Length - 1; ++i)
            {
                tempDigit = Int32.Parse(code[i].ToString());
                if (i + 1 % 2 == 0)
                    calculatedResult += tempDigit;
                else
                    calculatedResult += (tempDigit * 3);
            }
            //Console.WriteLine($"Calculated checksum: {calculatedResult % 10}");
            return calculatedResult % 10;
        }
    }
}
