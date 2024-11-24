using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    //Shadowing : When a derived class defines a new method with the same name as a method in the base class, but the new method hides the base class method.

    //Overriding : When a derived class redefines a base class method with the same name, signature, and return type using the override keyword.

    class BaseClass
    {
        public void Display() // Non-virtual method
        {
            Console.WriteLine("BaseClass Display Method (Non-Virtual)");
        }

        public virtual void Show() // Virtual method
        {
            Console.WriteLine("BaseClass Show Method (Virtual)");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("DerivedClass Display Method (Shadowing)");
        }

        // Overriding the Show method
        public override void Show()
        {
            Console.WriteLine("DerivedClass Show Method (Overriding)");
        }
    }

    class Shadow_OverrideProgram
    {
        static void Main()
        {
            BaseClass baseObj = new BaseClass();
            BaseClass baseRefToDerived = new DerivedClass();
            DerivedClass derivedObj = new DerivedClass();

            Console.WriteLine("Calling Display():");
            baseObj.Display();          // Output: BaseClass Display Method (Non-Virtual)
            baseRefToDerived.Display(); // Output: BaseClass Display Method (Non-Virtual)
            derivedObj.Display();       // Output: DerivedClass Display Method (Shadowing)

            Console.WriteLine("\nCalling Show():");
            baseObj.Show();             // Output: BaseClass Show Method (Virtual)
            baseRefToDerived.Show();    // Output: DerivedClass Show Method (Overriding)
            derivedObj.Show();          // Output: DerivedClass Show Method (Overriding)
        }
    }



}
