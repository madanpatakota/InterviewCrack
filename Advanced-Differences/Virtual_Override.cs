using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //The virtual keyword is used to define a method in a base class that can be overridden by derived classes.
    //The override keyword is used in a derived class to provide a specific implementation for a method that is inherited from a base class.
    class Animal
    {
        // Virtual method in the base class
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal
    {
        // Override the Speak method in the derived class
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class VirtualOverrideProgram
    {
        static void Main()
        {
            // Create an instance of Dog
            Animal animal = new Dog();
            animal.Speak(); // Calls the overridden method in Dog class
        }
    }

}
