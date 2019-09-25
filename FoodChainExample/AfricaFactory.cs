using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainExample
{
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbibore CreateHerbivore()
        {
            return new Zebra();
        }
    }
}
