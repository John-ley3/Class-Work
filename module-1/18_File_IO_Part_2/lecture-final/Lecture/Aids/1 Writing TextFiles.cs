using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "output.txt";
            string fullPath = Path.Combine(directory, filename);

            // Creates a new stream writer
            using (StreamWriter sw = new StreamWriter(fullPath,true))
            {
                // Prints the current datetime
                sw.WriteLine(DateTime.UtcNow);
                // Prints Hello World!
                sw.WriteLine("Hello World!");
                // Prints blank line
                sw.WriteLine("");
                // Prints
                // Tech
                // Elevator
                sw.WriteLine("Tech");
                sw.WriteLine("Elevator");

                // Print Tech Elevator
                sw.Write("Tech ");
                sw.Write("Elevator");
            }


            // After the using statement ends, file has now been written
            // and closed for further writing
        }


        
    }
}
