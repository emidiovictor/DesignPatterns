using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToyFactoryExample
{
    public class Duck : Toy
    {
        public override Color GetColor()
        {
            return Color.Yellow;
        }

        public override TimeSpan GetHetingTime()
        {
            return TimeSpan.FromMinutes(5);
        }

        public override int GetPowderQuantity()
        {
            return 60;
        }
    }
}
