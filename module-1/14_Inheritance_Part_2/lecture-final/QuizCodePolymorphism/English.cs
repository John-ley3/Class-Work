using System;
using System.Collections.Generic;
using System.Text;

namespace QuizCodePolymorphism
{
    public class English : IGreeting
    {
        public string Greeting
        {
            get { return "Hello!"; }
        }
    }
}
