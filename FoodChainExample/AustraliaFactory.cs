using System;
using System.Collections.Generic;
using System.Text;

namespace FoodChainExample
{
    public class AustraliaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Dingo();
        }

     

        public override Herbibore CreateHerbivore()
        {
            return new Kangaroo();
        }
    }
}
