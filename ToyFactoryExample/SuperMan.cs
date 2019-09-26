using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToyFactoryExample
{
    public class SuperMan : Toy
    {
        public override Color GetColor()
        {
            return Color.Blue;
        }

        public override TimeSpan GetHetingTime()
        {
            return TimeSpan.FromMinutes(1);
        }

        public override int GetPowderQuantity()
        {
            return 20;
        }
    }
}
