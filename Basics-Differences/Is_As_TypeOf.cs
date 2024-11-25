using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    /*
    is:
    Checks whether the obj is of type string. It prints a message based on the result.

    as:
    Attempts to safely cast obj to a string.

    typeof
    Retrieves the type of the string and prints it.
     */
    class ExperienceCandidatesProgram
    {
        static void Main()
        {
            object obj = "Hello, C#!";

            // Using 'is'
            if (obj is string)
            {
                Console.WriteLine("Using 'is': The object is a string.");
            }
            else
            {
                Console.WriteLine("Using 'is': The object is not a string.");
            }

            // Using 'as'
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine($"Using 'as': Safe cast succeeded - {str}");
            }
            else
            {
                Console.WriteLine("Using 'as': Safe cast failed.");
            }

            // Using 'typeof'
            Type objType = typeof(string);
            Console.WriteLine($"Using 'typeof': The type of string is {objType}");

            // Demonstrating typeof with a comparison
            if (obj.GetType() == typeof(string))
            {
                Console.WriteLine("Using 'typeof' and GetType(): The object is of type string.");
            }
            else
            {
                Console.WriteLine("Using 'typeof' and GetType(): The object is not of type string.");
            }
        }
    }

}
