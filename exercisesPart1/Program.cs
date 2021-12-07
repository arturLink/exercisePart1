using System;

namespace exercisesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write program that asks for users first and lasts name
            //the program greets the user by their name
            //the program asks the use to enter their year of birth and calculates users age
            //if the user older than 13, then the program displays "Welcome to Instagram"
            //otherwise program displays "You are too young for the app"

            string firstName;
            string lastName;
            int yob;
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Hi, {firstName} {lastName}");
            Console.WriteLine("Enter you year of birth: ");
            yob = Convert.ToInt32(Console.ReadLine());
            
            int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());
            int age = currentYear - yob;
            if (age < 13)
                Console.WriteLine("You are not old enough for the app");
            else
                Console.WriteLine("Welcome to the app");

        }
    }
}
