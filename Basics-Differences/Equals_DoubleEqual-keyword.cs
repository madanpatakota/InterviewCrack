using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{
    class Person5
    {
        public string Name;

        public Person5(string name)
        {
            Name = name;
        }

        // Overriding Equals to compare the content (Name) of the Person objects
        public override bool Equals(object obj)
        {
            if (obj is Person5 otherPerson)
            {
                return this.Name == otherPerson.Name;
            }
            return false;
        }
    }

    public class EqualsToProgram
    {
        public static void Main()
        {
            // Example with Value Types (int)
            int num1 = 10;
            int num2 = 10;
            Console.WriteLine("Value Types:");
            Console.WriteLine("Using ==: " + (num1 == num2));  // True, compares values
            Console.WriteLine("Using Equals: " + num1.Equals(num2));  // True, compares values

            // Example with Reference Types (Person class)
            Person5 person1 = new Person5("Alice");
            Person5 person2 = new Person5("Alice");
            Person5 person3 = person1;

            Console.WriteLine("\nReference Types:");
            Console.WriteLine("Using == (Reference Comparison): " + (person1 == person2));  // False, compares references
            Console.WriteLine("Using Equals (Content Comparison): " + person1.Equals(person2));  // True, compares content
            Console.WriteLine("Using == (Same Reference): " + (person1 == person3));  // True, compares references
        }
    }
}
