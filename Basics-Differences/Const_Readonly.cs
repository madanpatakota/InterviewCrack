using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicCandidates
{
    // A compile-time constant.
    // Its value is assigned at declaration and cannot be changed later.
    // Must be initialized during declaration.

    //  A runtime constant.
    // Its value can be assigned either:At the time of declaration.Inside the constructor (allowing dynamic initialization).
    class BasicCandidatesProgram
    {
        // const: Compile-time constant
        public const double Pi = 3.14159;

        // readonly: Runtime constant
        public readonly int MyReadonlyValue;

        // Constructor to initialize readonly value
        public BasicCandidatesProgram(int value)
        {
            MyReadonlyValue = value; // Can assign value here
        }

        static void Main()
        {
            // Accessing const value
            Console.WriteLine($"Value of Pi (const): {Pi}");

            // Creating an object and accessing readonly value
            BasicCandidatesProgram obj1 = new BasicCandidatesProgram(42);
            BasicCandidatesProgram obj2 = new BasicCandidatesProgram(100);

            Console.WriteLine($"Readonly value (obj1): {obj1.MyReadonlyValue}");
            Console.WriteLine($"Readonly value (obj2): {obj2.MyReadonlyValue}");

            // Uncommenting below lines will cause errors:
            // Pi = 3.14; // Error: Cannot modify a const
            // obj1.MyReadonlyValue = 50; // Error: Cannot modify a readonly field
        }
    }

}
