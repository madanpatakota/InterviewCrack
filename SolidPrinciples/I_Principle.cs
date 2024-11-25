using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.SolidPrinciples
{
    //I : A client should not be forced to implement interfaces it does not use.

    //Instead of creating large, all-encompassing interfaces, break them into smaller, more specific ones.
    //Each interface should only have methods relevant to the specific behavior it represents.


    public interface IAnimal
    {
        void Eat();
        void Fly();  // Not all animals can fly
    }

    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
        public void Fly()
        {
            throw new NotImplementedException(); // Dogs can't fly
        }
    }



    //After I
    // Split interfaces into smaller, focused ones
    public interface ICanEat
    {
        void Eat();
    }

    public interface ICanFly
    {
        void Fly();
    }

    // Dog only implements what it needs
    public class Cat : ICanEat
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
    }

    // Bird implements both eating and flying
    public class Bird : ICanEat, ICanFly
    {
        public void Eat()
        {
            Console.WriteLine("Bird is eating.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }


    class IPrincipleProgram
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();

            Bird bird = new Bird();
            bird.Eat();
            bird.Fly();
        }
    }




}
