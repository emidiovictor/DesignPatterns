using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToyFactoryExample
{
    public class FireTruck : Toy
    {
        

        public override Color GetColor()
        {
            return Color.Red;
        }

        public override TimeSpan GetHetingTime()
        {
            return TimeSpan.FromMinutes(2);
        }

        public override int GetPowderQuantity()
        {
            return 40;
        }
    }
}
