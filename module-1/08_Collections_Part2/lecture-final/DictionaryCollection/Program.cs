using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person / Height Database");
            Console.WriteLine();

            Console.Write("Would you like to enter another person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            // 1. Let's create a new Dictionary that could hold string, ints
            //      | "Josh"    | 70 |
            //      | "Bob"     | 72 |
            //      | "John"    | 75 |
            //      | "Jack"    | 73 |
            Dictionary<string, int> personDatabase = new Dictionary<string, int>();

            while (input == "yes" || input == "y")
            {
                Console.Write("What is the person's name?: ");
                string name = Console.ReadLine();

                Console.Write("What is the person's height (in inches)?: ");
                int height = int.Parse(Console.ReadLine());

                // 2. Check to see if that name is in the dictionary
                //      bool exists = dictionaryVariable.ContainsKey(key)
                bool exists = personDatabase.ContainsKey(name.ToLower());    // <-- change this

                if (!exists)
                {
                    Console.WriteLine($"Adding {name} with new value.");
                    // 3. Put the name and height into the dictionary
                    //      dictionaryVariable[key] = value;
                    //      OR dictionaryVariable.Add(key, value);
                    personDatabase.Add(name.ToLower(), height);
                    personDatabase[name.ToLower()] = height;
                }
                else
                {
                    Console.WriteLine($"Overwriting {name} with new value.");
                    // 4. Overwrite the current key with a new value
                    //      dictionaryVariable[key] = value;
                    string key = name.ToLower();
                    personDatabase[key] = height;
                }


                Console.WriteLine();
                Console.Write("Would you like to enter another person (yes/no)? ");
                input = Console.ReadLine().ToLower();
            }

            Console.Write("Type \"all\" to print all names OR \"search\" to print out single name or \"average\" to print average height: ");
            input = Console.ReadLine().ToLower();

            if (input == "search")
            {
                Console.Write("Which name are you looking for? ");
                input = Console.ReadLine();

                //5. Let's get a specific name from the dictionary
                if(personDatabase.ContainsKey(input.ToLower()))
                {
                    int personHeight = personDatabase[input.ToLower()];
                    Console.WriteLine($"{input}'s height is {personHeight} inches.");
                }

            }
            else if (input == "all")
            {
                Console.WriteLine();
                Console.WriteLine(".... printing ...");

                //6. Let's print each item in the dictionary
                foreach(KeyValuePair<string,int> kvp in personDatabase)
                {
                    string key = kvp.Key;
                    int value = kvp.Value;
                    Console.WriteLine($"{key} is {value} inches tall");
                }

            }
            //7. Let's get the average height of the people in the dictionary
            else if(input == "average")
            {
                Console.WriteLine();
                Console.WriteLine(".... printing heights ...");
                int totalHeight = 0;
                foreach(int personHeight in personDatabase.Values)
                {
                    totalHeight += personHeight;
                }
                Console.WriteLine($"The average height is {totalHeight / personDatabase.Values.Count}");
            }

            Console.WriteLine();
            Console.WriteLine("Done...");

            // Demo for hashset
            string[] colors = { "blue", "green", "green", "yellow" };
            List<string> listColors = new List<string>();
            HashSet<string> hashColors = new HashSet<string>();
            for(int i = 0; i < colors.Length; i++)
            {
                listColors.Add(colors[i]);
                hashColors.Add(colors[i]);
            }


            Console.ReadLine();
        }

        static void PrintDictionary(Dictionary<string, int> database)
        {
            // Looping through a dictionary involves using a foreach loop
            // to look at each item, which is a key-value pair
        }
    }
}
