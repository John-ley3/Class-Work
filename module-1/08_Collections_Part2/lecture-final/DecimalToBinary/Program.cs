using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal number separate by spaces: ");
            string input = Console.ReadLine();
            string[] decimalNumbers = input.Split(' ');

            for (int i = 0; i < decimalNumbers.Length; i++)
            {
                string binary = "";

                int numberToConvert = int.Parse(decimalNumbers[i]);
                while(numberToConvert > 0)
                {
                    binary = (numberToConvert % 2) + binary;
                    numberToConvert = numberToConvert / 2;
                }

                Console.WriteLine($"{decimalNumbers[i]} in binary is {binary}");
            }
        }
    }
}
