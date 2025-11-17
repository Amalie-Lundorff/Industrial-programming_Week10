

using System;

namespace DigitSumForeach

{
    class program
    {
        int DigitSum(string input)
        {
            int sum = 0;
            
            foreach (char c in input)
                {
                string s=c.ToString();
                int num = int.Parse(s);
                sum = sum + num;
                
                }
            return sum;
        }

        static void Main(string[] args)
        {
            program p = new program();
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();
            
            int result = p.DigitSum(input);
            Console.WriteLine("sum: " + result);
        }
    }
}