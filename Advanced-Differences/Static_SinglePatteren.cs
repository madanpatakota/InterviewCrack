using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //private SingletonExample() { }

    //Generally private constructor we are going to use in maintian the single instance of the class.

    public class SingletonExample
    {
        // Singleton instance (lazy initialization)
        private static SingletonExample _instance;

        // Private constructor to prevent external instantiation
        private SingletonExample() { }

        // Public property to get the instance
        public static SingletonExample Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonExample();  // Create the instance if not already created
                }
                return _instance;
            }
        }

        // A simple method to show that the instance works
        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton!");
        }
    }

    public static class CalculatorStatic
    {
        public static int Counter = 0;

        public static void Add(int a, int b)
        {
            Counter++;
            Console.WriteLine("Static Add Result: " + (a + b));
        }
    }

    class StaticSingletonProgram
    {
        static void Main()
        {

            // Static Example
            CalculatorStatic.Add(5, 10); // Accessing static method directly
            Console.WriteLine("Static Variable: " + CalculatorStatic.Counter); // Accessing static variable

            // Accessing the Singleton instance
            var singleton1 = SingletonExample.Instance;
            var singleton2 = SingletonExample.Instance;

            // Checking if both references point to the same instance
            Console.WriteLine("Both instances are the same: " + (singleton1 == singleton2));

            // Call a method on the Singleton instance
            singleton1.ShowMessage(); // Output: Hello from Singleton!
        }
    }

}
