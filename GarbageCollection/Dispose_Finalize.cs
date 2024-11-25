using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.GarbageCollection
{
    //   Dispose: Use when you need explicit and timely cleanup of resources (e.g., file streams, database connections). Works well with the using statement.


    //Finalize: Use as a fallback to release unmanaged resources in case Dispose is not explicitly called.


    public class ResourceManager3 : IDisposable
    {
        private bool disposed = false;

        // Finalizer (destructor)
        ~ResourceManager3()
        {
            // Cleanup for unmanaged resources
            Dispose(false);
            Console.WriteLine("Finalize called.");
        }

        // Dispose method (IDisposable implementation)
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent the finalizer from running
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Cleanup for managed resources
                    Console.WriteLine("Disposing managed resources.");
                }

                // Cleanup for unmanaged resources
                Console.WriteLine("Disposing unmanaged resources.");
                disposed = true;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Using Dispose:");
            using (var resource = new ResourceManager3())
            {
                // Use the resource
            }

            Console.WriteLine("\nWithout Dispose (Finalize will be called):");
            var resourceWithoutDispose = new ResourceManager3();
            // No explicit Dispose call here; Finalize will clean up
        }
    }

}
