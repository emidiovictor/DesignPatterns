using System;

namespace FoodChainExample
{
    public class Dingo : Carnivore
    {
        public override void Eat(Herbibore herbibore)
        {
            Console.WriteLine($"{this.GetType().Name} eats {herbibore.GetType().Name}");

        }
    }
}