using System;


/*
 * 
 * Explanation:
   ================
IDisposable Interface: The ResourceManager class implements IDisposable and defines the Dispose() method to release resources.


using Statement: When the using block ends, Dispose() is automatically called to clean up resources, ensuring no resources are left unreleased.

Dispose(bool disposing): This method ensures that managed resources are cleaned up first (if disposing is true), and unmanaged resources are always cleaned up. The destructor ensures cleanup if Dispose() is not called explicitly.
 * 
 * 
 */

public class ResourceManager : IDisposable
{
    private bool disposed = false;  // To detect redundant calls

    // Simulating an unmanaged resource (e.g., file handle)
    public void OpenResource()
    {
        Console.WriteLine("Resource Opened");
    }

    // Dispose method to release resources
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Overloaded Dispose method to release resources
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Release managed resources
                Console.WriteLine("Releasing managed resources...");
            }

            // Release unmanaged resources
            Console.WriteLine("Releasing unmanaged resources...");

            disposed = true;
        }
    }

    // Destructor (finalizer) to ensure Dispose is called if not done explicitly
    ~ResourceManager()
    {
        Dispose(false);
    }
}

class IDisposableProgram
{
    static void Main()
    {
        // Using 'using' statement to automatically call Dispose
        using (ResourceManager rm = new ResourceManager())
        {
            rm.OpenResource();
        } // Dispose() is automatically called at the end of the using block
    }
}
