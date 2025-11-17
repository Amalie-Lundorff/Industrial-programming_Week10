//Programmet her skal vise om det første tal er et "multiplum" af et det andet ved at tjekke om resten er 0

using System;

namespace MultiplesOfNumbers
{
    class Program
    {
        //Der laves en funktion
        static void Main(string[] args)
        {
        //Datatypen er en string    
        Console.WriteLine("Enter dividend");
        double dividend = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter divisor");
        double divisor = double.Parse(Console.ReadLine());
        double reminder = dividend / divisor;
        
        //Laver modellen
        if(reminder == 0)
            Console.WriteLine("Multiplies");
        else
            Console.WriteLine("Not Multiplies");
        }
    }
}