
using System;

namespace DigitSumModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indsæt et nummer");
            int number = int.Parse(Console.ReadLine());
            
            int sum = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}

