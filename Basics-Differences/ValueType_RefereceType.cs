using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
    /*
     
    Value Types: Stored directly in the stack. 
    When assigned to another variable, the value is copied. Changes to one variable do not affect the other.
    
    Reference Types: Stored in the heap,
    When assigned to another variable, both variables refer to the same object in memory. Changes to one variable affect the other.

    */
    // Reference type (class)

    public class Employee
    {
        public string Name;
        public int Age;

    }


    public class ValueTypeRefTypeMain
    {
        static void Main()
        {
            // Example of Value Type (int)
            int num1 = 5;
            int num2 = num1;  // num2 gets a copy of num1's value
            num1 = 10;         // Changing num1 does not affect num2

            Console.WriteLine("Value Type - num1: " + num1);  // num1: 10
            Console.WriteLine("Value Type - num2: " + num2);  // num2: 5

            // Example of Reference Type (Employee class)
            Employee emp1 = new Employee();
            emp1.Name = "Alice";
            emp1.Age = 28;

            Employee emp2 = emp1;  // emp2 references the same object as emp1
            emp1.Age = 30;         // Changing emp1 also affects emp2

            Console.WriteLine("Reference Type - emp1: " + emp1.Name + ", Age: " + emp1.Age);  // Age: 30
            Console.WriteLine("Reference Type - emp2: " + emp2.Name + ", Age: " + emp2.Age);  // Age: 30
        }
    }

    
}
