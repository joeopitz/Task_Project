using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Task_Project.Program;

// Look into creating a seperate form to display the tasks, for now just get it to register the tasks

namespace Task_Project
{
    public partial class Form1 : Form
    {
        List<Program.Task> tasks = new List<Program.Task>();

        public Form1()
        {
            InitializeComponent();
            taskProgress.Maximum = 100;  // Set the maximum value of the progress bar to 100
            UpdateProgressBar();         // Call this method to set initial state
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Read input from text boxes
            string name = txtTaskName.Text;
            float time = float.Parse(txtTime.Text); // Be sure to add error handling here
            float due = float.Parse(txtDue.Text);     // Be sure to add error handling here
            float spent = float.Parse(txtSpent.Text);

            // Create and add the task
            tasks.Add(new Program.Task(name, time, due, spent));
            if (tasks.Count() == 1)
            {
                ShowTasks();
            }
            else
            {
                tasks = Program.Solve(tasks);
                ShowTasks();
            }

            // Clear the text boxes after adding the task
            txtTaskName.Clear();
            txtTime.Clear();
            txtDue.Clear();
        }

        private void ShowTasks()
        {
            checkedListTasks.Items.Clear();  // Clear existing items
            foreach (var task in tasks)
            {
                checkedListTasks.Items.Add(task, false); // Add each task with unchecked status
            }
        }

        private void UpdateProgressBar()
        {
            // Grab the total number of tasks, along with the number of completed tasks
            int totalTasks = tasks.Count;
            int completedTasks = tasks.Count(t => t.IsCompleted);  

            if (totalTasks > 0)
            {
                // Percentage Calculator
                int progressPercentage = (int)((float)completedTasks / totalTasks * 100);
                taskProgress.Value = progressPercentage;  // Set the progress bar value
                labelProgress.Text = $"{progressPercentage}%";// Completed";  // Update the label with the percentage
            }
            else
            {
                // If no tasks are completed
                taskProgress.Value = 0;
                labelProgress.Text = "0%";
            }
        }
        private void checkedListTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Delay the action until the check state has actually changed
            this.BeginInvoke(new Action(() =>
            {
                // Grab the selected task
                Program.Task task = tasks[e.Index];
                // Update task list with the new check state
                task.IsCompleted = e.NewValue == CheckState.Checked;  
                // Assign the specified task at a specific spot
                tasks[e.Index] = task;
                UpdateProgressBar();  
            }));
        }

    }
}
