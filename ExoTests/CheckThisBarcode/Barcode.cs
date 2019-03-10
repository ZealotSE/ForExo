using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThisBarcode
{
    static class Barcode
    {
        public static bool Check(string code,int type)
        {
            StringBuilder newCode = new StringBuilder(code);    
            int targetLength;

            //check second argument
            if (type != 1 && type != 2) 
                throw new ArgumentException("Invalid barcode type argument");
            targetLength = type == 1 ? 8 : 13;

            //check if string contains characters
            if (!IsDigitsOnly(newCode.ToString()))
                throw new ArgumentException("String doesnt contains digits only");
                
            //check if barcode is shortened by first 0 - add it
            if(newCode.Length != targetLength)
            {
                if (newCode[0] == '0')
                    newCode.Insert(0, '0');
            }

            //check if barcode has valid length
            if (newCode.Length != targetLength && newCode.Length != targetLength + 2)
                throw new ArgumentException("Invalid barcode length");
            //barcode has add-on - remove it
            else if (newCode.Length == targetLength + 2)
                newCode.Remove(targetLength, 2);
            Console.WriteLine(newCode);

            return true;
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
    }
}
