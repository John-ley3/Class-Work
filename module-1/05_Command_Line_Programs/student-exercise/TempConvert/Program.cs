using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing to console to get temperature from user
            Console.WriteLine("Please enter the temperature: ");
            string inputTemp = Console.ReadLine();

            //Writing to console to get temperature unit for calculations
            Console.WriteLine("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string inputUnit = Console.ReadLine();

            int userTemp = int.Parse(inputTemp);

            if (inputUnit == "C" || inputUnit == "c") //int convertedTemp = userTemp * 1.8 + 32;
            {
                Console.WriteLine($"{userTemp}{inputUnit} is {userTemp * 1.8 + 32}F");
            }
            else if(inputUnit == "F" || inputUnit == "f")
            {
                Console.WriteLine($"{userTemp}{inputUnit} is {(userTemp - 32) / 1.8}C");
            }
        }
    }
}
