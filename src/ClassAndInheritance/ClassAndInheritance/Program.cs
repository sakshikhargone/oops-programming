using System;

namespace ClassAndInheritance

{
    /// <summary>
    /* Class and Inheritance:
       Create a class hierarchy for different types of vehicles (e.g., Car, Bicycle, Motorcycle).
       Each class should have properties like  "Model," and methods like "Start" and "Stop."
       Create instances of these classes and demonstrate inheritance by calling methods from the base clas
    */
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Bicycle();
            Vehicle v3 = new Motorcycle();
            
            v1.Name = "BMW";
            v1.Model = 2023;

            v2.Name = "Bicycle";
            v2.Model = 123;

            v3.Name = "Herohonda";
            v3.Model = 1;

            v1.Start();
            v2.Stop();
            v3.Start();
        }
    }

    public abstract class Vehicle
    {
        public string Name { get; set; }

        public int Model { get; set; }

        public abstract void Start();

        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Please start " + Name + " of model no.  " + Model);
        }

        public override void Stop()
        {
            Console.WriteLine("Please stop " + Name + "of model no." + Model);
        }
    }

    public class Bicycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Please start " + Name + " of model no.  " + Model);
        }

        public override void Stop()
        {
            Console.WriteLine("Please stop " + Name + "of model no. " + Model);
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Please start " + Name + " of model no.  " + Model);
        }

        public override void Stop()
        {
            Console.WriteLine("Please stop " + Name + "of model no." + Model);
        }
    }
}