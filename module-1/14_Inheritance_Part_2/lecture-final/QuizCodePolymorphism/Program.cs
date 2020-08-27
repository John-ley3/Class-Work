using System;

namespace QuizCodePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IGreeting[] greetings = new IGreeting[3] { new French(), new English(), new Spanish() };
            foreach (IGreeting g in greetings)
            {
                Console.Write(g.Greeting + " ");
            }
        }
    }
}
