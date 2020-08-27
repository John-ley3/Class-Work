using System;

namespace DiscountCalculator
{
    class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Discount Calculator");
            // Prompt the user for a discount price
            // The answer needs to be saved as a double
            Console.Write("Enter a discount price as a decimal (w/out percentage): ");
            string userInput = Console.ReadLine();
            double discount = double.Parse(userInput);

            // Prompt the user for a series of prices
            Console.Write("Enter the prices separate by spaces: ");
            userInput = Console.ReadLine();
            // Split the string up into separate values

            //string[] priceArray = userInput.Split(' ');
            // splits the string on several different characters.
            string [] priceArray = userInput.Split(new char[] { ' ', ',', '|' });
            // Loop through each value in the priceArray

            for (int index = 0; index < priceArray.Length; index++)
            {
                // Read the individual value as a decimal
                decimal originalPrice = decimal.Parse(priceArray[index]);
                // Cast the discount value to a decimal to allow the calculation
                decimal amountOff = originalPrice * (decimal)discount;
                // Calculate sales price
                decimal salesPrice = originalPrice - amountOff;
                // Let's tell the user their savings
                Console.WriteLine($"Original Price: {originalPrice:C2} | Sale Price: {salesPrice:C2}");

            }
        }
    }
}
