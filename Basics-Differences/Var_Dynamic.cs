using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    /*
     * var: 1.The type is determined at compile-time based on the assigned value.
     *      2.The compiler checks the type at compile time. 
     *      If you try to perform an operation that is not valid for that type, it results in a compile-time error
     *     
     *     
     *     
     * dynamic: 1.The type is determined at runtime.
     *          2. The compiler does not perform any type checking. Any errors related to  the type are caught at runtime,
     */
    public class Var_DynamicProgram
    {
        static void Main()
        {
            // Using var: Type is determined at compile-time
            var number = "10";  // 'number' is inferred as 'int'
            Console.WriteLine("Var Example: " + number);  // Output: 10
                                                          // number = "Hello";  // Compile-time error: Cannot assign a string to an int variable

            // Using dynamic: Type is determined at runtime
            dynamic obj = 10;  // Initially, obj is an int
            Console.WriteLine("Dynamic Example: " + obj);  // Output: 10

            obj = "Hello";  // Changing the type at runtime
            Console.WriteLine("Dynamic Example after change: " + obj);  // Output: Hello
        }

    }
}
