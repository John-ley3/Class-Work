using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the maximum Fibonacci value: ");
            int limit = int.Parse(Console.ReadLine());

            int previous = 0;

            Console.Write(previous);

            int next = 1;
            while(next < limit)
            {
                Console.Write(", " + next);

                int temp = previous + next;
                previous = next;
                next = temp;

            }
        }
    }
}
