using System;

namespace CheckThisBarcode
{
    class Program
    {
        static void Main(string[] args)
        {                                                           //Expected:
            Console.WriteLine(Barcode.Check("96385074", 1));        //96385074
            Console.WriteLine(Barcode.Check("0385074", 1));         //00385074
            Console.WriteLine(Barcode.Check("038507442", 1));       //00385074
            Console.WriteLine(Barcode.Check("1234567890", 1));      //12345678
            Console.WriteLine(Barcode.Check("0123456", 1));         //00123456
            Console.WriteLine(Barcode.Check("1234567890123", 2));   //1234567890123
            Console.WriteLine(Barcode.Check("023456789012", 2));    //0023456789012
            Console.WriteLine(Barcode.Check("02345678901222", 2));  //0023456789012
            Console.WriteLine(Barcode.Check("9876543212211", 2));   //9876543212211
            Console.WriteLine(Barcode.Check("098765432122", 2));    //098765432122
            Console.WriteLine(Barcode.Check("0987654321", 2));      //System.ArgumentException
            Console.ReadKey();
        }
    }
}
