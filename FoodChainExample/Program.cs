using System;

namespace FoodChainExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var africaFactory = new AfricaFactory();
            var eco = new Ecosystem(africaFactory);
            eco.Run();

            var autraliaFactory = new AustraliaFactory();
            var eco2 = new Ecosystem(autraliaFactory);
            eco2.Run();
        }
    }


    public class Ecosystem
    {

        private Herbibore _herbibore;
        private Carnivore _carnivore;

        public Ecosystem(ContinentFactory factory)
        {
            _herbibore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void Run()
        {
            _carnivore.Eat(_herbibore);
        }

    }
}
