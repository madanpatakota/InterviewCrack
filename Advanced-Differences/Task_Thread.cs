using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //The Thread class is explicitly started with thread.Start().
    //Manual management: The thread must be managed manually, such as managing its lifecycle.



    //The Task class is managed by the Task Parallel Library (TPL) and is started with Task.Run().
    //Simplified asynchronous execution: Tasks are usually easier to work with for I/O-bound operations or parallelism.
    class TaskThreadProgram
    {
        static void Main()
        {
            // 1. Thread Example
            Console.WriteLine("Thread Example:");
            Thread thread = new Thread(PrintMessageFromThread);
            thread.Start(); // Starts a new thread

            // 2. Task Example
            Console.WriteLine("\nTask Example:");
            Task task = Task.Run(() => PrintMessageFromTask()); // Starts a task (asynchronous)
            task.Wait(); // Waits for the task to complete
        }

        // Method for Thread
        static void PrintMessageFromThread()
        {
            Console.WriteLine("This is from the Thread.");
        }

        // Method for Task
        static void PrintMessageFromTask()
        {
            Console.WriteLine("This is from the Task.");
        }
    }

}
