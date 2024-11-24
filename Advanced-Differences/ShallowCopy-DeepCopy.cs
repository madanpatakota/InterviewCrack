using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    using System;


    //Shallow copy : The shallowCopy refers to the same instance as original.
    //Deep Copy :  The shallowCopy refers to the new instance as original.

    class Person1
    {
        public string Name;
        public int Age;
    }

    class ShallowCopyDeepCopyProgram
    {
        static void Main()
        {
            // Create an original Person object
            Person1 original = new Person1 { Name = "John", Age = 30 };

            // Shallow Copy: Copying reference (both refer to the same object)
            Person1 shallowCopy = original;

            // Deep Copy: Creating a new instance with copied values (completely independent)
            Person1 deepCopy = new Person1 { Name = original.Name, Age = original.Age };

            // Modify the copied objects
            shallowCopy.Name = "David";  // This affects the original object because both reference the same instance
            deepCopy.Age = 25;  // This does NOT affect the original object

            // Output values
            Console.WriteLine("Original Name: " + original.Name);   // Output: David
            Console.WriteLine("Original Age: " + original.Age);     // Output: 30

            Console.WriteLine("Shallow Copy Name: " + shallowCopy.Name);  // Output: David
            Console.WriteLine("Shallow Copy Age: " + shallowCopy.Age);    // Output: 30

            Console.WriteLine("Deep Copy Name: " + deepCopy.Name);        // Output: John
            Console.WriteLine("Deep Copy Age: " + deepCopy.Age);          // Output: 25
        }
    }

}
