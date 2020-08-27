using ExceptionHandling.Exceptions;
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following cities: ");
            string[] cities = new string[] { "Pittsburgh", "Philadelphia", "Erie", "Cranberry" };
            try
            {
                Console.WriteLine(cities[0]);
                Console.WriteLine(cities[1]);
                Console.WriteLine(cities[2]);
                Console.WriteLine(cities[3]);
                Console.WriteLine(cities[4]); // This line throws an exception
            }
            catch (Exception e)
            {
                // Flow goes if there is an exception
                Console.WriteLine("Ooops something went horribly wrong: " + e.Message);
            }
            Console.WriteLine("are all in Pennsylvania");
            Console.WriteLine();
            try
            {
                Console.WriteLine("Nothing up my sleeve....");
                DoSomethingDangerous(); // throws error
                Console.WriteLine("See, nothing to fear");
            }
            catch (Exception e)
            {
                Console.WriteLine("I got you covered");
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("The standard work week is 40 hours.");
                Console.WriteLine("How many hours did you work this week? >>> ");
                int hoursWorked = int.Parse(Console.ReadLine());
                int overtimeHours = hoursWorked - 40;
                Console.WriteLine("You worked " + overtimeHours + " hours of overtime.");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Wow! That's a lot of hours, I can't even...");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please, numbers only.");
            }
            catch (Exception e)
            {
                Console.WriteLine("You did something wrong. Shame.");
            }

            // Let's do some hotel work
            int nights = -3;
            int numberOfGuests = 2;
            try
            {
                decimal amountOwed = CalculateHotelRoomCharges(nights, numberOfGuests);
                Console.WriteLine("Total owed for " + numberOfGuests + " guests for " + nights + " nights is $" + amountOwed);

            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            try
            {
                decimal finalBalance = Withdraw(60000M);
                Console.WriteLine("The final balance is " + finalBalance);
            }
            catch (OverdraftException ode)
            {
                Console.WriteLine("An overdraft exception was caught");
                Console.WriteLine(ode.Message);
            }
            finally
            {
                Console.WriteLine("Thankyou for banking with Fly By Night Banking");
            }
        }
        private static void DoSomethingDangerous()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i;  // this line will throw an Exception once i reaches 5
            }
            Console.WriteLine("Look Ma, no Exceptions!");  // This line will not execute because an Exception will be thrown inside the for loop
        }

        private static decimal CalculateHotelRoomCharges(int nights, int numberOfGuests)
        {
            const decimal ExtraGuestCharge = 20M;
            const decimal RoomRate = 85M;

            if (nights < 1)
            {
                throw new ArgumentOutOfRangeException("nights", nights, "Minimum stay is one night");
            }
            if (numberOfGuests < 1)
            {
                throw new ArgumentOutOfRangeException("numberOfGuests", numberOfGuests, "Minimum number of guests is 1");
            }

            int numberOfExtraGuests = 0;
            if (numberOfGuests > 4)
            {
                numberOfExtraGuests = numberOfGuests - 4;
            }
            decimal dailyRate = RoomRate + (ExtraGuestCharge * numberOfExtraGuests);
            return dailyRate * nights;
        }

        private static decimal Withdraw(decimal amount)
        {
            const decimal StartingBalance = 5000.00M;

            decimal finalBalance = StartingBalance - amount;
            if (finalBalance < 0)
            {
                throw new OverdraftException("You can't get that much money!", finalBalance);
            }
            return finalBalance;

        }
    }
}
