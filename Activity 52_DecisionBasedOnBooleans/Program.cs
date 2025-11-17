
using System;

namespace DecisionBasedOnBooleans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the lecture topic interesting?");
            var topic = Console.ReadLine();
            
            Console.WriteLine("Does one of your freinds join?");
            var friend = Console.ReadLine();
            
            Console.WriteLine("Do you have problems with the assignment?");
            var problem = Console.ReadLine();
            
            //Boolean Variables
            var isInteresting = topic == "y";
            var friendJoins = friend == "y";
            var hasProblem = problem == "y";
            
            //Boolean logic - Kombinere

            if (isInteresting && (friendJoins || hasProblem))
            {
                Console.WriteLine("Go.");
            }
            else
            {
                Console.WriteLine("Stay.");
            }
        
        }
    }
}

