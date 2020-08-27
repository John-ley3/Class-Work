using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCodePolymorphism
{
    public class Spanish : IGreeting
    {
        public string Greeting
        {
            get { return "Hola!"; }
        }
    }
}
