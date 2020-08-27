using System;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Path: ");
            string path = Console.ReadLine();

            File QuizMaker = new File();
            QuizMaker.questionTextPath = path;
            
            QuizMaker.startQuiz();
        }
    }
}
