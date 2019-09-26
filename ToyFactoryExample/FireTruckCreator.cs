using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactoryExample
{
    public class FireTruckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new FireTruck();
        }
    }
}
