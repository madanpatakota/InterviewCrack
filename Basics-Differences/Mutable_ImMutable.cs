using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    //string is mutable
    //stringbuilder is a immutable.

    public class Mutable_ImmutableProgram
    {
        public static void Main()
        {
            // Example of Mutable
            int[] mutableArray = { 1, 2, 3 };
            Console.WriteLine("Mutable Example:");
            Console.WriteLine("Original Array: " + string.Join(", ", mutableArray));

            mutableArray[0] = 10; // Modifying the array
            Console.WriteLine("Modified Array: " + string.Join(", ", mutableArray));

            // Example of Immutable
            string immutableString = "Hello";
            Console.WriteLine("\nImmutable Example:");
            Console.WriteLine("Original String: " + immutableString);

            string newString = immutableString.Replace("Hello", "World"); // Creates a new string
            Console.WriteLine("Modified String (New Instance): " + newString);
            Console.WriteLine("Original String (Unchanged): " + immutableString);
        }
    }
}
