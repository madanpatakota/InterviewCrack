using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    /*
     * The Dispose Pattern is a way to properly release unmanaged resources in C# by implementing the IDisposable interface. 
     */
    public class ResourceManager1 : IDisposable
    {
        // Flag to indicate whether Dispose has been called
        private bool disposed = false;

        // Simulating an unmanaged resource (e.g., file handle, database connection)
        private IntPtr unmanagedResource;

        // Managed resource
        private System.IO.StreamWriter managedResource;

        public ResourceManager1()
        {
            // Simulating allocation of unmanaged and managed resources
            unmanagedResource = (IntPtr)12345; // Dummy unmanaged resource
            managedResource = new System.IO.StreamWriter("resource.txt");
        }

        // Dispose method to release resources
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Overloaded Dispose method to handle resource cleanup
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Release managed resources
                    if (managedResource != null)
                    {
                        managedResource.Close();
                        managedResource = null;
                    }
                }

                // Release unmanaged resources
                if (unmanagedResource != IntPtr.Zero)
                {
                    unmanagedResource = IntPtr.Zero;
                    Console.WriteLine("Unmanaged resources released.");
                }

                disposed = true;
            }
        }

        // Finalizer (destructor) to clean up unmanaged resources if Dispose is not called
        ~ResourceManager1()
        {
            Dispose(false);
        }
    }

    class Program
    {
        static void Main()
        {
            // Using the Dispose pattern
            using (ResourceManager1 rm = new ResourceManager1())
            {
                // Use the resources
                Console.WriteLine("Using resources...");
            } // Dispose() is automatically called here

            // Alternatively, without using statement (Dispose() must be called manually)
            ResourceManager1 rm2 = new ResourceManager1();
            rm2.Dispose(); // Explicitly call Dispose() when done
        }
    }
}
