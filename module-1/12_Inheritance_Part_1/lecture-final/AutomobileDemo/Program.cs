using AutomobileDemo.Classes;
using System;

namespace AutomobileDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int bestRange;
            Automobile genericSedan = new Automobile();
            Automobile miniVan = new Automobile(7, 25, 20);


            if (genericSedan.GetTotalRangeInMiles() > miniVan.GetTotalRangeInMiles())

            {
                bestRange = genericSedan.GetTotalRangeInMiles();
            }

            else

            {
                bestRange = miniVan.GetTotalRangeInMiles();
            }


            Console.WriteLine(bestRange);
        }
    }
}
