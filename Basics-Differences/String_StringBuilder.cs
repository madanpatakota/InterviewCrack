using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //string immutable
    //stringbuilder is a mutable.

    class String_StringBuilderProgram
    {
        static void Main()
        {
            // Using string (immutable)
            string str = "Hello";
            str += " World";  // Creates a new string object each time
            Console.WriteLine("String Result: " + str);

            // Using StringBuilder (mutable)
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");  // Modifies the existing StringBuilder object
            Console.WriteLine("StringBuilder Result: " + sb.ToString());
        }
    }
    
}
