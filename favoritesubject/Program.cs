using System;

namespace favoritesubject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite subject?");

            var userInput = Console.ReadLine();

            switch ((userInput)
   )
            {
                case "math":
                    Console.WriteLine("Math is the worst!");
                    break;

                case "science":
                    Console.WriteLine("People think science is for nerds.");
                    break;

                case "literature":
                    Console.WriteLine("I love to read Greek tragedies.");
                    break;

                case "gym":
                    Console.WriteLine("Known for jocks");
                    break;

                case "history":
                    Console.WriteLine("I love history!");
                    break;

                default:
                    Console.WriteLine("I have no interest in school.");
                    break;
            }
        }
    }
}