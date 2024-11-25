using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    //Runs under the control of the .NET CLR (Common Language Runtime)
    //Executes directly on the operating system without CLR support.
    class ManagedCode_UnManagedCode
    {

        // Unmanaged Code: Importing MessageBox from User32.dll (Windows API)
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void Main()
        {
            // Managed Code: Code executed under the control of CLR
            Console.WriteLine("This is Managed Code!");

            // Calling Unmanaged Code
            Console.WriteLine("Calling Unmanaged Code to display a MessageBox...");
            MessageBox(IntPtr.Zero, "Hello, this is Unmanaged Code!", "Unmanaged Code Example", 0);
        }
    }
}

/*
Explanation:
Managed Code:

The Console.WriteLine is part of the managed code, executed and controlled by the CLR.
Unmanaged Code:

The MessageBox function from user32.dll is unmanaged code written in C and directly interacts with the operating system.
Unmanaged Code (like MessageBox) directly interacts with the OS, without CLR's control
*/