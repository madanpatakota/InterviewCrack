using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates
{

    /*
     *  Interface : Its provides the rules do't provide any addition related details 
     *  Abstract  : It provides the rules same time it provides shared behaviour also.
     * 
     */

    // Interface: Defines common rules for all fighters
    public interface IFighter
    {
        string Name { get; set; }
        void Attack(string targetName);
    }

    // Class 1: Knight implements the IFighter interface
    public class Knight : IFighter
    {
        public string Name { get; set; }
        public void Attack(string targetName)
        {
            Console.WriteLine($"{Name} attacks {targetName} with a sword!");
        }
    }

    // Class 2: Robot implements the IFighter interface
    public class Robot : IFighter
    {
        public string Name { get; set; }
        public void Attack(string targetName)
        {
            Console.WriteLine($"{Name} shoots lasers at {targetName}!");
        }
    }

    // Program: Both Knight and Robot use the same rules, but with unique implementations
    public static class Program
    {
        public static void Main()
        {
            IFighter knight = new Knight { Name = "Sir Lancelot" };
            knight.Attack("Dragon");

            IFighter robot = new Robot { Name = "RoboWarrior" };
            robot.Attack("Enemy Tank");


            /*Abstract*/
            // Program: Vehicles share common functionality and provide their own implementation for movement
            Vehicle car = new Car { Name = "Tesla" };
            car.StartEngine();
            car.Move();

            Vehicle airplane = new Airplane { Name = "Boeing 747" };
            airplane.StartEngine();
            airplane.Move();
        }
    }



    /*Abstract class*/
    // Abstract Class: Defines shared behaviors and rules for vehicles
    public abstract class Vehicle
    {
        public string Name { get; set; }

        // Shared behavior: Starting the engine
        public void StartEngine()
        {
            Console.WriteLine($"{Name}'s engine starts!");
        }

        // Abstract method: Each vehicle defines its own way to move
        public abstract void Move();
    }

    // Class 1: Car extends Vehicle
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} drives on the road.");
        }
    }

    // Class 2: Airplane extends Vehicle
    public class Airplane : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} flies in the sky.");
        }
    }

}
