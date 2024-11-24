using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //1. static constructor doesnot accept the parameters
    //Wen you want to share the common key for all instances of the class then you can use staic constructor and give the value
    // So that value serveed same value into all the instances of the class


    //2.Nonstatic constructor will accept the parameters

    class StaticNonStaticExample
    {
        // Static field
        public static int StaticField;

        // Instance field
        public int InstanceField;

        // Static constructor
        static StaticNonStaticExample()
        {
            StaticField = 100;  // Initialize static field
            Console.WriteLine("Static constructor called.");
        }

        // Non-static constructor (instance constructor)
        public StaticNonStaticExample(int value)
        {
            InstanceField = value;  // Initialize instance field
            Console.WriteLine("Non-static constructor called.");
        }

        public void DisplayFields()
        {
            Console.WriteLine("StaticField: " + StaticField);
            Console.WriteLine("InstanceField: " + InstanceField);
        }
    }

    public class StaticConstructorNonStaticConstructorExampleProgram
    {
        public static void Main()
        {
            // Static constructor is called when the class is first accessed
            Console.WriteLine("Before creating instance...");
            Console.WriteLine("StaticField: " + StaticNonStaticExample.StaticField);  // Access static member
            Console.WriteLine();

            // Non-static constructor is called when creating an instance
            StaticNonStaticExample obj1 = new StaticNonStaticExample(10);
            obj1.DisplayFields();

            Console.WriteLine();

            // Creating another instance
            StaticNonStaticExample obj2 = new StaticNonStaticExample(20);
            obj2.DisplayFields();
        }
    }

}
