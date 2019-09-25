using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainExample
{
    public abstract class ContinentFactory
    {

        public abstract Carnivore CreateCarnivore();
        public abstract Herbibore CreateHerbivore();
    }
}
