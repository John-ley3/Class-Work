using System;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With Strings!");

            // Ask the user for their first name
            Console.WriteLine("Please enter your first name. Pretty please.");
            // Grab the information the user entered
            string firstName = Console.ReadLine();

            // Greet our user
            Console.WriteLine("Well, hello " + firstName + "!");

            // Ask for a last name
            Console.WriteLine("How about a last name?");
            // Wait for the user to enter their last name and hit enter
            string lastName = Console.ReadLine();

            Console.WriteLine("Your name is " + firstName + " " + lastName);
            // Use the $ infront of a string to allow variable substitution.
            Console.WriteLine($"Formally, your name is {lastName}, {firstName}");

            // let's work with our first loop
            Console.WriteLine("What phrase do you want to see over and over and over?");
            string phrase = Console.ReadLine();
            // How many times?
            Console.WriteLine("How many times?");
            string numberOfTimes = Console.ReadLine();
            int timesForLoop = int.Parse(numberOfTimes);
            for(int i = 0; i < timesForLoop; i++)
            {
                Console.WriteLine(phrase);
            }

            // While loop
            bool isDone = false;
            while(!isDone)
            {
                int second = DateTime.Now.Second;
                Console.WriteLine($"{firstName} {lastName}: Current Second: {second}");
                if(second > 30)
                {
                    isDone = true;
                }
            }

            // do while
            do
            {
                int second = DateTime.Now.Second;
                Console.WriteLine($"Do while {firstName} {lastName}: Current Second: {second}");
                if (second > 30)
                {
                    isDone = true;
                }
            } while (!isDone);

            // Ask for a number until they enter a number less than 5
            int numberProvided = 5;
            do
            {
                Console.WriteLine("Enter a number less than 5");
                string numberEntered = Console.ReadLine();
                numberProvided = int.Parse(numberEntered);
            } while (numberProvided > 5);

        }
    }
}
