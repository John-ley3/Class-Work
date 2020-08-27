using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCodePolymorphism
{
    public class French : IGreeting
    {
        public string Greeting
        {
            get { return "Bonjour!"; }
        }
    }
}
