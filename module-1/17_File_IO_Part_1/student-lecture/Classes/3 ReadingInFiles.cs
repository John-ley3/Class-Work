using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lecture.Classes
{
    /*
    * Reading files for input involves working with streams and readers.
    */
    public static class ReadingInFiles
    {

        // Reading in a character file involves working with classes that derive from 
        // TextWriter. TextWriter is an abstract class for working with character input.
        // The StreamReader inherits from TextWriter and that is often used.
        public static void ReadACharacterFile()
        {
            // Start with the file path to input
            string directory = Environment.CurrentDirectory;
            string fileName = "Input.txt";

            // Create the full path
            string fullPath = Path.Combine(directory, fileName);

            // Wrap the effort in a try-catch block to handle any exceptions
            try
            {
                //Open a StreamReader with the using statement
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    // Read the file until the end of the stream is reached
                    // EndOfStream is a "marker" that the stream uses to determine 
                    // if it has reached the end
                    // As we read forward the marker moves forward like a typewriter.
                    while (!sr.EndOfStream)
                    {
                        // Read in the line
                        string line = sr.ReadLine();

                        // Print it to the screen
                        Console.WriteLine(line);
                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error reading file");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ya lost me.");
            }

        }
    }
}
//catch a specific type of Exception
