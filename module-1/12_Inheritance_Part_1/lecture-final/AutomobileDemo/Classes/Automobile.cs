using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileDemo.Classes
{
    public class Automobile

    {

        private int numberOfPassengers;
        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
        }

        private int milesPerGallon;
        public int MilesPerGallon
        {
            get { return milesPerGallon; }
        }

        private int gasTankCapacityInGallons;
        public int GasTankCapacityInGallons
        {
            get { return gasTankCapacityInGallons; }
        }

        public Automobile()
        {
            numberOfPassengers = 5;
            milesPerGallon = 30;
            gasTankCapacityInGallons = 15;
        }

        public Automobile(int numberOfPassengers, int milesPerGallon, int gasTankCapacityInGallons)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.milesPerGallon = milesPerGallon;
            this.gasTankCapacityInGallons = gasTankCapacityInGallons;
        }

        public int GetTotalRangeInMiles()
        {
            return gasTankCapacityInGallons * milesPerGallon;
        }
    }
}
