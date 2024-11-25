using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    class Ref_OutProgram
    {
        // ref: The parameter is initialized before passing and can be used before modifying.
        static void RefExample(ref int number)
        {
            // The value can be read and modified
            Console.WriteLine("In RefExample (Before modification): " + number);
            number += 10; // Modifies the passed value
        }

        // out: The parameter is not initialized before passing and must be assigned inside the method.
        static void OutExample(out int number)
        {
            // number is not initialized before passing
            number = 20; // Must assign a value inside the method

            //number += 20; //Will Give the exception.
            Console.WriteLine("In OutExample: " + number);
        }

        static void Main()
        {
            // ref: The parameter must be initialized before passing
            int refValue = 5;
            Console.WriteLine("Before RefExample: " + refValue);
            RefExample(ref refValue); // The value can be read and modified inside the method
            Console.WriteLine("After RefExample: " + refValue);

            // out: The parameter must be assigned inside the method
            int outValue;
            OutExample(out outValue); // The variable doesn't need to be initialized, but must be assigned inside the method
            Console.WriteLine("After OutExample: " + outValue);
        }
    }
}
