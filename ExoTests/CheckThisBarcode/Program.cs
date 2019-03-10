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
            
            Barcode.Check("96385075", 1);
            Console.ReadKey();
        }
    }
}
