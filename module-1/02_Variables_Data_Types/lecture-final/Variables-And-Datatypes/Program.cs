﻿using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            int numberOfExercises;
            numberOfExercises = 26;

            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */
            double half;
            half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */
            string name;
            name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly;
            seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */
            string myFavoriteLanguage;
            myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */
            // Const means the value cannot change
            const float pi = 3.1416F; 
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */
            string yourName = "Henry Edwards";
            Console.WriteLine(yourName);
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int numberOfButtons = 4;
            Console.WriteLine(numberOfButtons);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            double batteryLeft = 0.77;
            Console.WriteLine(batteryLeft);
            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int firstNumber = 121;
            int secondNumber = 27;
            int result = firstNumber - secondNumber;
            Console.WriteLine(result);
            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double sum = 12.3 + 32.1;
            Console.WriteLine(sum);
            /*
            12. Create a string that holds your full name.
            */
            string fullName = "Henry Edwards";
            Console.WriteLine(fullName);
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + fullName;
            Console.WriteLine(greeting);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            greeting = greeting + " Esquire";
            Console.WriteLine(greeting);
            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            greeting += " III";
            Console.WriteLine(greeting);
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string creepyMovie = "Saw ";
            creepyMovie = creepyMovie + 2;
            Console.WriteLine(creepyMovie);
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            creepyMovie += 0;
            Console.WriteLine(creepyMovie);
            /*
            18. What is 4.4 divided by 2.2?
            */
            double divisionResult = 4.4 / 2.2;
            Console.WriteLine(divisionResult);
            /*
            19. What is 5.4 divided by 2?
            */
            divisionResult = 5.4 / 2;
            Console.WriteLine(divisionResult);
            /* CASTING */
            int firstNewNumber = 15;
            double secondNewNumber = 150;
            secondNewNumber = firstNewNumber;
            firstNewNumber = (int)secondNewNumber;
            /*
            20. What is 5 divided by 2?
            */
            Console.WriteLine(5 / 2); // in 2 because of integer math
            double fiveDividedByTwo = 5 / 2;
            Console.WriteLine("Five / 2: " + fiveDividedByTwo);
            /*
            21. What is 5.0 divided by 2?
            */
            Console.WriteLine(5.0 / 2);
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            decimal bankBalance = 1234.56M;
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;
            Console.WriteLine(remainder);
            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int variableOne = 3;
            int variableTwo = 1000000000;
            int answer = variableOne * variableTwo;
            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercises = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

        }
    }
}
