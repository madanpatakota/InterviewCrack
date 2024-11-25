using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.SolidPrinciples
{
    /*
     * Objects of a superclass should be replaceable with objects of its subclasses 
     * without affecting the functionality of the program."
     * 
     * A subclass should be able to substitute its superclass without altering the correct behavior of the system.
     */


    /*without L
     * 
    public class Bird1
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    public class Penguin : Bird1
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly.");
        }
    }

    */



    /* With - After the L -*/// Abstract class or interface to define behavior
    public abstract class Bird
    {
        public abstract void Move(); // Generalize the movement behavior
    }

    public class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }

}
