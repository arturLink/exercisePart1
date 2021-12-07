using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //the program asks user to enter their fav colour
            //displays personality traits
            //whatever they are
            //if user enters anything else program displays "you are (userInput) unicorn"
            
            Console.WriteLine("Enter your favorite colour: ");
            string colour = Console.ReadLine();
            if (colour == "Red")
                Console.WriteLine($"You picked {colour}. You are romantic.");
            else if (colour == "Blue")
                Console.WriteLine($"You picked {colour}. You are reliable.");
            else if (colour == "Yellow")
                Console.WriteLine($"You picked {colour}. You are cheerful.");
            else
                Console.WriteLine($"You picked {colour}. You are unicorn.");
        }
    }
}
