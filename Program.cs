using System;
using System.Collections.Generic;

namespace Mock_Assessment_2
{
    class Program
    {
        public static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            tasks.Add("Wake up");
            tasks.Add("Brush your vegetables");
            tasks.Add("Eat your teeth");

            Console.WriteLine("Here are your tasks for today.");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }

            Console.WriteLine("\nWhat would you like to do to the list?");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+=");
            Console.WriteLine("1. Add a task to the list.\n2. Finish a task.\n3. Grab a task.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Please write out what needs to be done.");
                string addList = Console.ReadLine();

                AddTask(addList);
            }
            else if (input == "2")
            {
                Console.WriteLine("Which task did you finish? (Case sensative)");
                string finishTask = Console.ReadLine();

                FinishTask(finishTask);
            }
            else if (input == "3")
            {
                Console.WriteLine("Which task would you like? (Numbers only please)");
                int grabTask = int.Parse(Console.ReadLine());
                GetTask(grabTask);
            }
            else
            {
                Console.WriteLine("WRONG! GOODBYE!");
            }

        }
        public static void AddTask(string a)
        {
            tasks.Add(a);

            Console.WriteLine("Here is your new list.");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
        }
        public static bool FinishTask(string f)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks.Contains(f))
                {
                    Console.WriteLine("Okay, we will check that off of the list.");
                    Console.WriteLine($"{f} was completed: {true}.\n");
                    Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                    tasks.Remove(f);
                    break;
                }
                else if(!tasks.Contains(f))
                {
                    Console.WriteLine("Sorry, that is not on the list.");
                    Console.WriteLine($"{f} was completed: {false}.\n");
                    Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                    break;
                }
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
            return true;
        }
        public static string GetTask(int g)
        {
            try
            {
                _ = tasks[g] == tasks[0];

                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                Console.WriteLine("Here is your list item.");
                Console.WriteLine($"{tasks[g]}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error", e);
            }
            return "";
        }
    }
}
