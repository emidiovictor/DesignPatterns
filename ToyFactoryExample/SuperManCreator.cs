using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactoryExample
{
    public class SuperManCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {

            return new SuperMan();
        }
    }
}
