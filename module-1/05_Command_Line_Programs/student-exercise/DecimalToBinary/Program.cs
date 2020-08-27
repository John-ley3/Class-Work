using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");
            string userInput = Console.ReadLine();

            string[] numArray = userInput.Split(" ");

            for(int index = 0; index < numArray.Length; index++)
            {
                long currentNum = long.Parse(numArray[index]);
                
                Console.WriteLine($"{currentNum} in binary is {Convert.ToString((int)currentNum, 2)} ");
            }
            
        }
    }
}
