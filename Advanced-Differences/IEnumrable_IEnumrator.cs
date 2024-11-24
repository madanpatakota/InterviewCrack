using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExperienceCandidates.Differences
{
    internal class IEnumrable_IEnumrator
    {
    }
    //IEnumerable works at the collection level and provides an iterator.
    //IEnumerator works at the element level, managing the current position during iteration.
    public class FruitCollection : IEnumerable
    {
        private readonly string[] _fruits = { "Apple", "Banana", "Cherry", "Mango" };

        // Implement GetEnumerator method from IEnumerable
        public IEnumerator GetEnumerator()
        {
            return new FruitEnumerator(_fruits); // Use our custom enumerator
        }
    }

    public class FruitEnumerator : IEnumerator
    {
        private readonly string[] _fruits; // Collection to iterate
        private int _position = -1;        // Current position, starts before the first element

        public object Current => throw new NotImplementedException();

        public FruitEnumerator(string[] fruits)
        {
            _fruits = fruits;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    public static class Enuramable_IEnumrabtorProgram
    {
        public static void Main()
        {
            // Create an instance of the custom collection
            FruitCollection fruits = new FruitCollection();

            // Iterate using foreach (internally calls GetEnumerator())
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }



}
