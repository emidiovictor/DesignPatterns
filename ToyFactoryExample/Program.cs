using System;

namespace ToyFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyCreator creator = null;

            Console.WriteLine("Creating a fireTruck");
            creator = new FireTruckCreator();
            creator.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating a Superman");
            creator = new SuperManCreator();
            creator.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating a Duck");
            creator = new DuckCreator();
            creator.MakeToy();
            Console.WriteLine();
        }
    }
}
