using System;
using System.Collections.Generic;
using System.Text;

namespace ToyFactoryExample
{
    public class DuckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new Duck();
        }
    }
}
