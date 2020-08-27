using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int difference;
            difference = 121 - 27;
            Console.WriteLine(difference);
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double addition = 12.3 + 32.1;
            Console.WriteLine(addition);
            /*
            12. Create a string that holds your full name.
            */
            string fullName = "John Ley";
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string helloName = "Hello " + fullName;
            Console.WriteLine(helloName);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            fullName += " Esquire";
            Console.WriteLine(fullName);
            /*
            15. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string saw = "Saw" + 2;
            Console.WriteLine(saw);
            /*
            16. Add a 0 onto the end of the variable from exercise 16.
            */
            saw += 0;
            Console.WriteLine(saw);
            /*
            17. What is 4.4 divided by 2.2?
            */
            double product = 4.4 / 2.2;
            Console.WriteLine(product);
            /*
            18. What is 5.4 divided by 2?
            */
            double secondProduct = 5.4 / 2;
            Console.WriteLine(secondProduct);
        }
    }
}
