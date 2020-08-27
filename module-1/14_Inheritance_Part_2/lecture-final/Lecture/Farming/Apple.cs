using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lecture.Farming
{
    public class Apple : ISingable, ISellable
    {
        public string Name { get; }

        public string Sound { get; }

        public Apple(string appleVariety)
        {
            Name = appleVariety;
            Sound = "Crunch";
        }
        public string MakeSoundOnce()
        {
            return "Crunch ";
        }

        public string MakeSoundTwice()
        {
            return MakeSoundOnce() + MakeSoundOnce();
        }

        public decimal GetSalesPrice()
        {
            decimal perApple = 0M;
            switch (Name)
            {
                case "Red Delicious":
                    perApple = .1M;
                    break;
                case "Golden Delicious":
                    perApple = .25M;
                    break;
                case "Honeycrisp":
                    perApple = 1M;
                    break;
                case "Granny Smith":
                    perApple = .5M;
                    break;
                default:
                    perApple = .75M;
                    break;
            }
            return perApple;
        }

        public override string ToString()
        {
            return Name + " For: $" + GetSalesPrice() + " each";
        }
    }
}
