/*
 *  Author: Joe Opitz
 *  
 *  Assignment: Greedy Task Scheduler GUI Project (Final Project)
 *  
 *  Description: Given 4 user inputs within the GUI, this algorithm will sort the tasks by what
 *      the user should complete first. It will also recommend how much time you should spend starting
 *      a task that does not need to be done at an early date.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using System.CodeDom.Compiler;

namespace Task_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Allows for application of my GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Initialize a list of tasks
            List<Task> tasks = new List<Task>();


            /*
             *  Code that was used for the initial algorithm, but unnecessary with the GUI that I created
             * 
            // Add individual tasks into a list of tasks
            Task taskB = new Task("Task B", 0, 3);
            tasks.Add(taskB);
            tasks.Add(new Task("Task A", 3, 4));
            tasks.Add(new Task("Task D", 5, 8));
            tasks.Add(new Task("Task C", 2, 6));
            tasks.Add(new Task("Task E", 4, 7));
            tasks.Add(new Task("Task F", 1, 6));
            tasks.Add(new Task("Task G", 6, 9));
            tasks.Add(new Task("Task H", 7, 9));
            tasks.Add(new Task("Task I", 9, 14));

            Console.WriteLine("Tasks before sorting:");

            ShowList(tasks);

            tasks = Solve(tasks);

            Console.WriteLine("Tasks after solving:");

            ShowList(tasks);
            */
        }
        public class Task : IComparable<Task>
        {
            // Initialize all variables, format allows for user inputs
            public string Name { get; set; }
            public float Time { get; set; }
            public float Due { get; set; }
            public bool IsChecked { get; set; }
            public bool IsCompleted { get; set; }
            public float Spent { get; set; }


            // Default constructor
            public Task(string name, float time, float due, float spent)
            {
                Name = name;
                Time = time;
                Due = due;
                Spent = spent;
            }

            // Function to allow the user to make comparisons between certain tasks, by recommending what is due first
            public int CompareTo(Task other)
            {
                return Due.CompareTo(other.Due);
            }

            // Allows each task to be printed in an easy-to-understand way
            public override string ToString()
            {
                return string.Format($"{Name}      Expected Time: {Time}      Due: {Due}");
            }
        }
        // Function to solve the greedy task scheduler algorithm
        // List must be sorted in order to work
        static public List<Task> Solve(List<Task> lists)
        {
            lists.Sort();

            Console.WriteLine("Tasks after sorting: ");

            ShowList(lists);

            // Initialize a temporary list to hold the tasks
            List<Task> res_tasks = new List<Task>();
            Task lastSelectedTask = null;

            Task temp = lists[1];
            float time = temp.Spent;

            // Loop to go through every individual task
            foreach (Task t in lists)
            {
                // Check if it's the first task 
               if (lastSelectedTask == null || t.Time <= time)
               {
                    // Add task to temporary list
                    res_tasks.Add(t);
                    // Update the last selected task
                    lastSelectedTask = t;
                    time = time - t.Time;
               }
               // Has the user work on it until the time that they said to work until
               // Good for assignments you have to chip away at.
               else if (t.Time > time)
                {
                    t.Time = t.Time - time;
                    res_tasks.Add(t);
                }
            }
                return res_tasks;
        }

        // Function to show the list of tasks
        static public void ShowList(List<Task> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
