using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_io_part1_exercises
{
    public class File
    {
        public string questionTextPath { get; set; }

        public void startQuiz()
        {
            int count = 0;
            int correctAnswers = 0;

            try {
                using (StreamReader sr = new StreamReader(questionTextPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] questionAnswerArray = line.Split('|');

                        Console.WriteLine(questionAnswerArray[count]);
                        Console.Write("Answer: ");
                        string answer = Console.ReadLine();
                        //Logic to check answer
                        string correctAnswer = null;
                        foreach (string word in questionAnswerArray)
                        {
                            if (word.Contains('*'))
                            {
                                correctAnswer = word;
                            }
                        }
                        if (correctAnswer.ToLower().Contains(answer.ToLower()))
                        {
                            Console.WriteLine("Correct!");
                            correctAnswers++;
                            Console.WriteLine($"Correct Answers: {correctAnswers}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Answer... ");
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Bad File Path...");
            }
            catch(Exception e)
            {
                Console.WriteLine("Don't know...");
            }
        }
    }
}
