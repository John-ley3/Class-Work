using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the Fibonacci number: ");
            string userInput = Console.ReadLine();

            int fibNum = int.Parse(userInput);
            int previousNum = 0;
            int currentNum = 1;
            int nextNum = 0;

            Console.WriteLine(previousNum);

            while (nextNum < fibNum)
            {
                nextNum = currentNum + previousNum;
                previousNum = currentNum;
                currentNum = nextNum;
                Console.WriteLine(previousNum);
            }

        }
    }
}