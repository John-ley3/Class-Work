using System;
using System.Collections.Generic;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {

            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.

            // Create a queue of strings

            Queue<string> queueOfStrings = new Queue<string>();

            // Add four tasks to the queue that you do every day

            queueOfStrings.Enqueue("shower");
            queueOfStrings.Enqueue("shave");
            queueOfStrings.Enqueue("code");
            queueOfStrings.Enqueue("Shop for Groceries");


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Print each task to the console in the order they were entered (FIFO)

            while(queueOfStrings.Count > 0)
            {
                Console.WriteLine(queueOfStrings.Dequeue());
            }

            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 

            // Create a stack of strings

            Stack<string> stringStack = new Stack<string>();

            // Add to the stack four things you might eat for breakfast

            stringStack.Push("Orange Juice");
            stringStack.Push("Waffles");
            stringStack.Push("Strawberries");
            stringStack.Push("Banana");

            ////////////////////
            // POPPING THE STACK
            ////////////////////

            // Print each breakfast item to the console in reverse order (LIFO)

            while(stringStack.Count > 0)
            {
                Console.WriteLine(stringStack.Pop());
            }

            Console.ReadLine();

        }
    }
}
