using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("Is the measurement in (m)eters, or (f)eet? ");
            string userUnit = Console.ReadLine();

            int userLength = int.Parse(userInput);

            if(userUnit == "m" || userUnit == "M")
            {
                Console.WriteLine($"{userLength}{userUnit} is {userLength * 3.2808399}f");
            }
            else if(userUnit == "f" || userUnit == "F")
            {
                Console.WriteLine($"{userLength}{userUnit} is {userLength * .3048}m");
            }

        }
    }
}
