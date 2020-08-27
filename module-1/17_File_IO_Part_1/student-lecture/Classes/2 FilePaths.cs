using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lecture.Classes
{
    /*
    * A path is a string that provides the location of a file or directory. 
    *
    * Working with paths is kind of tricky.
    *
    * The Path class is a static class that is able to perform operations 
    * on strings that represent folders and file paths.
    *    
    */

    public static class FilePaths
    {
        /*
        * The path class helps create a full path given a directory
        * and file name. 
        */
        public static void UsingPathToCombineTwoFilePaths()
        {
            string path1 = @"C:\Temp\Directory";
            string filename = @"filename.txt";
            // Generating a full path from a folder and a file name
            string fullPath = Path.Combine(path1, filename);
        }



        /*
        * The path class helps by getting the extension in a file name.
        */
        public static void GettingExtensions()
        {
            string path = @"C:\Temp\path.txt";

            // Get the extension from the path variable
            string extension = Path.GetExtension(path);

            // Change the extension in the path variable to .cs
            path = Path.ChangeExtension(path, ".cs");
        }

    }
}
