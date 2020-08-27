﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lecture.Classes
{
    public static class SummingUpNumbers
    {
        public static void ReadFile()
        {
            // Reading in a file of numbers
            string folder = Environment.CurrentDirectory;
            string filename = "numbers.txt";
            // get the full path
            string fullpath = Path.Combine(folder, filename);
            int sum = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fullpath))
                {
                    // Read until we get to the end of the file
                    while (!sr.EndOfStream)
                    {
                        // Read the line
                        string line = sr.ReadLine();
                        // Convert to a number
                        int number = 0;
                        // Another try to continue processing file if parse fails
                        try
                        {
                            number = int.Parse(line);
                        } catch(Exception e)
                        {

                        }
                        // Add to Sum
                        sum += number;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(sum);
            }

            Console.WriteLine("The sum is " + sum);
        }
    }
}