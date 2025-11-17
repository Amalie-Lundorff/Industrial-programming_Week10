//Skriv et program der kan læse to numre fra konsollen og vise det:
//Total (Sum)
//Gange (Product/Multiply)
//Divition (/Quotient)
//Minus (Multiply/Difference)
//Remainder
//Antag at brugeren altid skal give tal (integer numbers)

using System;

namespace AritmeticOperations

{
    class Program
    {
        //Her laves en funktion 
        static void Main()
        {
            //Data vises, at det skal indskrives
            Console.WriteLine("Indsæt det første nummer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Indsæt andet nummer");
            int b = int.Parse(Console.ReadLine());

            //Her spørges konsollen om at færdiggøre de matematiske kalkulationer
            Console.WriteLine("Result");
            Console.WriteLine(decimal.Add(a, b));
            Console.WriteLine(decimal.Multiply(a, b));
            Console.WriteLine(decimal.Subtract(a, b));
            Console.WriteLine(decimal.Divide(a, b));
            Console.WriteLine(decimal.Remainder(a, b));
        }
    }
}