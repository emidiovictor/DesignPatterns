using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToyFactoryExample
{
    public abstract class Toy
    {

        public abstract int GetPowderQuantity();

        public abstract TimeSpan GetHetingTime();

        public abstract Color GetColor();

    }

}
