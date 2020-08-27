using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal
    {
        public Cat() : base("Felix") { Sound = "Meow"; }

        public string MakeSoundOnce()
        {
            return "Meow";
        }

        public string MakeSoundTwice()
        {
            return "I said MEOW";
        }

        public override string Eat()
        {
            return "Throw food on floor";
        }
    }
}
