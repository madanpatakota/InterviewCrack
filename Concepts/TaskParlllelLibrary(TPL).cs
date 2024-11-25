using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace ExperienceCandidates
{

    //The Task Parallel Library(TPL) is a set of APIs in .NET that makes it easier to write parallel and asynchronous programs.TPL allows developers to handle multiple tasks concurrently, making better use of multi-core processors and improving the overall performance of applications.

    class TPLProgram
    {
        static void Main()
        {
            // Create a Task that runs in parallel
            Task task1 = Task.Run(() => PrintNumbers(1, 5));
            //This is used to create and start a task that runs a method asynchronously. It accepts a delegate that represents the method to run.
            Task task2 = Task.Run(() => PrintNumbers(6, 10));

            // Wait for both tasks to complete
            Task.WhenAll(task1, task2).Wait();
            //This method takes multiple tasks and waits for all of them to complete. It returns when all tasks are finished.

            Console.WriteLine("Both tasks are complete.");
        }

        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

}
