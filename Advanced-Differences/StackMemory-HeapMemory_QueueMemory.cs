using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    // 2 Major Differences:
    // 1. Stack Memory is used for primitive types and local variables, while Heap Memory is used for dynamically allocated objects.
    // 2. Queue is a data structure that stores data in FIFO (First In, First Out) order, not a memory type like stack and heap.


    //Heap we are allocate dynamic objects like classes
    //stack we are allcoate the primitive datatypes
    //Queue we wo't allocate any memory like stack and heap
    class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class StackHeapQueueProgram
    {
        static void Main()
        {
            // Stack Memory Example
            int stackVariable = 10; // Stored in stack
            Console.WriteLine("Stack Variable: " + stackVariable);

            // Heap Memory Example
            Person2 heapPerson = new Person2 { Name = "John", Age = 30 }; // Stored in heap
            Console.WriteLine("Heap Memory: " + heapPerson.Name + ", Age: " + heapPerson.Age);

            // Queue Memory Example (Queue is not a memory type, it's a data structure)
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");
            queue.Enqueue("Task 3");

            Console.WriteLine("\nQueue Memory (FIFO Order): ");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            
        }
    }

    


}
