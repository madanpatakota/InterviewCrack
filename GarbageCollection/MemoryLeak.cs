using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.GarbageCollection
{
    /*
     * A memory leak occurs when objects are not properly released from memory, causing the application to consume more memory over time and potentially leading to performance degradation or application crashes.
     * 
     */
    class MemoryLeakExample
    {
        private static List<byte[]> _memoryHolder = new List<byte[]>();

        public static void CreateMemoryLeak()
        {
            for (int i = 0; i < 1000; i++)
            {
                // Allocating memory without releasing it
                _memoryHolder.Add(new byte[1024 * 1024]); // 1 MB each
            }

            Console.WriteLine("Memory allocated but not released.");
        }
    }

    class MemoryLeakProgram
    {
        static void Main()
        {
            MemoryLeakExample.CreateMemoryLeak();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
