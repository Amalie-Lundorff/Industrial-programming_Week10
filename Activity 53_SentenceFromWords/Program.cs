//Programmet skal kunne sammensætte en sætning ud fra ord
using System;

namespace ScentenceFromWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words of a sentence one by one including punctuation:");

            var sentence = "";
            var finished = false;

            while (!finished)
            {
                var word = Console.ReadLine();

                if (sentence == "")
                    sentence = word;
                else
                    sentence = sentence + " " + word;
                
                if(word.EndsWith(" ") || word.EndsWith("!") || word.EndsWith("?"))
                    finished = true;
            }
            Console.WriteLine(sentence);
        }
    }
}

