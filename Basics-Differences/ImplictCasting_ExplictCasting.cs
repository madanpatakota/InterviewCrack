using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{

    /*
       
        Implicit Casting:
        ================
        Automatically performed by the compiler.
        Converts a smaller type to a larger type (e.g., int to float).
        No data loss occurs, so it's considered safe.
        Example: int → long, float → double.
     
        Explicit Casting:
        ================
        Requires manual casting using parentheses.
        Converts a larger type to a smaller type (e.g., double to int).
        Potential for data loss or runtime exceptions.
        Example: double → int, object → specific type.
      
     */


    class ExplicitImplicitProgram
    {
        static void Main()
        {
            // Implicit Casting: No need for explicit cast
            int intVal = 100;
            float floatVal = intVal;  // int -> float (safe)
            Console.WriteLine($"Implicit Casting: int ({intVal}) to float ({floatVal})");

            // Explicit Casting: Requires a cast
            double doubleVal = 123.45;
            int intResult = (int)doubleVal;  // double -> int (unsafe, data loss)
            Console.WriteLine($"Explicit Casting: double ({doubleVal}) to int ({intResult})");

            // Casting objects (Explicit Example)
            object obj = "Hello, World!";  // Implicit boxing
            string str = (string)obj;     // Explicit unboxing (safe if types match)
            Console.WriteLine($"Explicit Casting: object to string ({str})");
        }
    }

}
