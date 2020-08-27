using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Cow : FarmAnimal
    {
        public Cow(string name) : base(name) { Sound = "Mooooo"; }

        public override string Eat()
        {
            return "Chews on grass";
        }
    }
}
