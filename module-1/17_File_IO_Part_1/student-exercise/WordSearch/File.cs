using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordSearch
{
    public class File
    {
        public File(string fullPath)
        {
            FullPath = fullPath;
        }
        public string FullPath { get; }

        public void GetLineWithKeyword(string keyword)
        {
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(FullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        count++;
                        string line = sr.ReadLine();

                        if (line.Contains(keyword))
                        {
                            Console.WriteLine($"(Line #: {count}) {line}");
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading file!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Unkown error try again.");
            }
        }
    }
}
