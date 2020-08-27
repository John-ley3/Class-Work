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

        public override string MakeSoundOnce()
        {
            return Sound;
        }

        public override string MakeSoundTwice()
        {
            return $"{Sound} {Sound}";
        }

        public string WhatSeason()
        {
            return "Rabbit Season";
        }
    }
}
