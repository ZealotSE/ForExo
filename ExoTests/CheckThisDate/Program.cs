using System;

namespace TSzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateChecker.Check(2000, 1, 1));   //False
            Console.WriteLine(DateChecker.Check(2001, 1, 1));   //True
            Console.WriteLine(DateChecker.Check(2100, 1, 1));   //False
            Console.WriteLine(DateChecker.Check(2099, 1, 1));   //True
            Console.WriteLine(DateChecker.Check(2002, 4, 30));  //True
            Console.WriteLine(DateChecker.Check(2002, 4, 31));  //False
            Console.WriteLine(DateChecker.Check(2019, 2, 29));  //False
            Console.WriteLine(DateChecker.Check(2020, 2, 29));  //True
            Console.WriteLine(DateChecker.Check(2020, 6, 31));  //False
            Console.WriteLine(DateChecker.Check(2020, 6, 30));  //True
            Console.ReadKey();
        }
    }
}
