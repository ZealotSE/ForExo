using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThisBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Barcode.Check("01234567890123", 2);
            Console.ReadKey();
        }
    }
}
