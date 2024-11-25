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
    using System;
    using System.Collections.Generic;

    class MemoryLeakExample1 : IDisposable
    {
        private List<byte[]> _memoryHolder = new List<byte[]>(); // Instance field instead of static
        private bool _disposed = false;

        public void CreateMemoryLeak()
        {
            for (int i = 0; i < 1000; i++)
            {
                // Allocating memory
                _memoryHolder.Add(new byte[1024 * 1024]); // 1 MB each
            }

            Console.WriteLine("Memory allocated.");
        }

        // Implement Dispose method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Suppresses finalization to improve performance
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free managed resources
                    _memoryHolder.Clear();
                    Console.WriteLine("Managed resources released.");
                }

                // Free unmanaged resources here (if any)

                _disposed = true;
            }
        }

        // Destructor to handle cleanup if Dispose is not called
        ~MemoryLeakExample1()
        {
            Dispose(false);
            Console.WriteLine("Destructor called.");
        }
    }

    class MemoryLeakProgram1
    {
        static void Main()
        {
            // Use 'using' to ensure Dispose is called
            using (var example = new MemoryLeakExample1())
            {
                example.CreateMemoryLeak();
            }

            Console.WriteLine("Memory released. Press any key to exit...");
            Console.ReadKey();
        }
    }


}
