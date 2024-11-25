using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    class Person3
    {
        public string Name { get; set; }
        public Person3 Manager { get; set; }
    }
    class Null_Nullable_NullCoalescing_NullPropogation
    {
        public static void Main()
        {
            string name = null;
            Console.WriteLine($"Name is: {name ?? "No Name"}"); // Null coalescing

            // Nullable
            int? age = null;
            // Allows value types to store null(e.g., int ?, bool ?).
            Console.WriteLine($"Age is: {age?.ToString() ?? "Unknown"}"); // Null propagation and coalescing

            // Null Coalescing
            int? score = null;
            //Provides a default value if the left-hand side is null.
            int finalScore = score ?? 0; // Use default value 0 if score is null
            Console.WriteLine($"Final Score: {finalScore}");

            // Null Propagation
            Person3 person = null;
            string managerName = person?.Manager?.Name ?? "No Manager"; // Safely access nested property
            Console.WriteLine($"Manager Name: {managerName}");
            //Safely accesses members of an object, avoiding NullReferenceException.
        }
    }
}
