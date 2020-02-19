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
            //List of the things.

            Console.WriteLine("Here are your tasks for today.");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
            //Displays the list to see.

            Console.WriteLine("\nWhat would you like to do to the list?");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+=");
            Console.WriteLine("1. Add a task to the list.\n2. Finish a task.\n3. Grab a task.");
            string input = Console.ReadLine();
            //Asks the first question.
            //Each if else statements that follow are for the above response. If not, end program.

            if (input == "1")
            {
                Console.WriteLine("Please write out what needs to be done.");
                string addList = Console.ReadLine();
                //Make sure the variable grabbed matches the following Method parameter.

                AddTask(addList);
                //Asks for string parameter.
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
                //Asks for an int, must int.Parse();
            }
            else
            {
                Console.WriteLine("WRONG! GOODBYE!");
                //else catch statement
            }

        }
        public static void AddTask(string a)
        {
            tasks.Add(a);
            //Takes in the string from before (input) and adds it to the list.

            Console.WriteLine("Here is your new list.");
            Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
            //Displays the new list and closes.
        }
        public static bool FinishTask(string f)
        {
            for (int i = 0; i < tasks.Count; i++)
            //Same loop.
            {
                //Uses the Contains method to match if the new string is available in the tasks list
                if (tasks.Contains(f))
                {
                    Console.WriteLine("Okay, we will check that off of the list.");
                    Console.WriteLine($"{f} was completed: {true}.\n"); //Returns true.
                    Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                    tasks.Remove(f);//Removes the task when it is a match.
                    break;//Break just for safety.
                }
                //Otherwise returns false and does nothing.
                else if(!tasks.Contains(f))
                {
                    Console.WriteLine("Sorry, that is not on the list.");
                    Console.WriteLine($"{f} was completed: {false}.\n");
                    Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                    break;
                }
            }
            for (int i = 0; i < tasks.Count; i++) //Reposts the new list after the removal.
            {
                Console.WriteLine($"{i}: {tasks[i]}");
            }
            return true; //Must return a bool because it is not a void method.
        }
        public static string GetTask(int g)
        {
            try //Using try catch methods.
            {
                _ = tasks[g] == tasks[0];

                Console.WriteLine("=+=+=+=+=+=+=+=+=+=+=+==+=+=+==+=+=+==+=+=+==+=+=+==+=");
                Console.WriteLine("Here is your list item.");
                Console.WriteLine($"{tasks[g]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error", e);
            }
            return "";
        }
    }
}
