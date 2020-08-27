using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Create two lists of integers

            List<int> numList = new List<int>();

            numList.Add(3);

            List<int> secondNumList = new List<int>();

            secondNumList.Add(4);

            // Create list of strings

            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("string");

            // Write these variables to the console

            Console.WriteLine($"{numList[0]}\n{secondNumList[0]}\n{listOfStrings[0]}");

            // Discuss: What did you see on the console? Is that what you expected?

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////

            // Check if the first list you created is equal to the second list
            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?

            if(numList.Equals(secondNumList))
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            // Assign the first integer list to the second integer list

            numList = secondNumList;

            Console.WriteLine(numList[0]);

            // Check if the first list you created is equal to the second list
            // If they are equal, write "They are the same" to the console.
            // If they are not equal, write "They are not the same" to the console.
            // Discuss: Why did you get that result?

            if (numList.Equals(secondNumList))
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            /////////////////
            // ADDING ITEMS
            /////////////////

            // Add three numbers to one of the integer lists

            for(int i = 1; i < 4; i++)
            {
                numList.Add(i);
            }
            // Add four words to the list of strings

            for (int i = 1; i < 5; i++)
            {
                listOfStrings.Add($"string{i}");
            }

            //////////////////
            // ACCESSING BY INDEX
            //////////////////
            // Use a for loop to access each element by its index
            // Write each element to the console. 
            // Do this for both the integer list and the string list.

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
            }



            Console.ReadLine();

        }
    }
}
