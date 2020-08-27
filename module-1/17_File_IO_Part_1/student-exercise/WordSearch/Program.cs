using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.Write("Please enter the string to search: ");
            string searchString = Console.ReadLine();

            Console.Write("Please enter the file path: ");
            string filePath = Console.ReadLine();

            File openFile = new File(filePath);
            openFile.GetLineWithKeyword(searchString);
                
        }

        public void GetLineWithKeyword(string keyword, string filePath)
        {
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while(!sr.EndOfStream)
                    {
                        count++;
                        string line = sr.ReadLine();

                        if(line.Contains(keyword))
                        {
                            Console.WriteLine($"(Line #: {count}) {line}");
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error reading file!");

            }
            catch(Exception e)
            {
                Console.WriteLine("Unkown error try again.");
            }
        }
    }
}
