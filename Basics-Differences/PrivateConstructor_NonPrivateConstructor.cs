using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    /*Private Construtor
       A constructor that is marked with the private keyword, meaning it cannot be called from outside the class.

    Use case in :  Singleton pattern, Factory method.
    */


    class Singleton
    {
        // Private static instance of the class
        private static Singleton _instance;

        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
            Console.WriteLine("Singleton Instance Created!");
        }

        // Public method to access the single instance
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }


    class Person4
    {
        // Public constructor allows object creation from anywhere
        public Person4(string name)
        {
            Name = name;
            Console.WriteLine($"Person {Name} created!");
        }

        public string Name { get; set; }
    }

    class SingletonProgram
    {
        static void Main()
        {
            // Only allowed way to get the instance
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            // Proving both references are pointing to the same instance
            Console.WriteLine(ReferenceEquals(instance1, instance2));  // Output: True


            Person4 person = new Person4("John");
            Console.WriteLine($"Person's Name: {person.Name}");
        }
    }






}
