using System;

namespace FunctionDemo
{
    class Program
    {
   
        static void WelcomeUser(string name)
        {
            Console.WriteLine($"Welcome to the system, {name}!");
        }

       
        static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        
        static void CheckEligibility(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to proceed.");
            }
            else
            {
                Console.WriteLine("You are not eligible to proceed.");
            }
        }

        static void DisplayDateTime()
        {
            Console.WriteLine("Current date and time: " + DateTime.Now);
        }

        static void GreetInFilipino(string name)
        {
            Console.WriteLine($"Kamusta, {name}!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            WelcomeUser(name);
            GreetInFilipino(name);

            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Uppercase version: " + ToUpperCase(sentence));

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            CheckEligibility(age);

            DisplayDateTime();
        }
    }
}
