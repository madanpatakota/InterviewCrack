using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{

    //Converting a value type (e.g., int, float) to a reference type (e.g., object).
    //Converting a reference type (e.g., object) back to a value type.
    class Boxing_UnBoxing_Program
    {
        static void Main()
        {
            // Boxing: Converting value type to object
            int num = 42;            // Value type
            object boxedNum = num;   // Boxing

            Console.WriteLine($"Boxed Value: {boxedNum}");

            // Unboxing: Converting object back to value type
            int unboxedNum = (int)boxedNum; // Unboxing
            Console.WriteLine($"Unboxed Value: {unboxedNum}");
        }

    }
}
