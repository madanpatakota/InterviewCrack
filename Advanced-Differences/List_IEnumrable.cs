using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{
 
//List<T> allows adding, removing, and modifying elements.
//IEnumerable<T> is read-only and only supports iteration.

//List<T> supports indexing(list[index]) and provides methods like Add, Remove, etc.
//IEnumerable<T> only supports iteration(e.g., foreach) and does not provide indexing.
    internal class List_IEnumrable
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Adding and removing elements
            numbers.Add(6);
            numbers.Remove(3);

            // Accessing elements by index
            Console.WriteLine("Element at index 2: " + numbers[2]);

            // Iterating through the list
            Console.WriteLine("List elements:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }



            // IEnumerable from LINQ query
            IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);

            // Iterating through IEnumerable
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
