using System;

static class FizzBuzz
{
    private static int range = 100;

    public static void WriteToConsole()
    {
        for (int i = 1; i <= range; ++i)
        {
            Console.WriteLine(CheckMultiple(i));
        }
    }

    private static string CheckMultiple(int number)
    {
        return
            number % 15 == 0 ? "FizzBuzz" :
            number % 5 == 0 ? "Buzz" :
            number % 3 == 0 ? "Fizz" : number.ToString();
    }
}