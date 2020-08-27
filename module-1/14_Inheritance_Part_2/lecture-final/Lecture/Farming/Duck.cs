using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Duck : FarmAnimal,ISellable
    {
        public Duck() : base("Duck") { Sound = "Quack"; }

        public decimal GetSalesPrice()
        {
            return 5M;
        }


        public string WhatSeason()
        {
            return "Rabbit Season";
        }

        public override string Eat()
        {
            return "Eats algae";
        }
    }
}
