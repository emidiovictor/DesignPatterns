using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ToyFactoryExample
{
    public abstract class ToyCreator
    {

        protected abstract Toy CreateToy();

        public void MakeToy()
        {
            Toy toy = CreateToy();
            int grams = toy.GetPowderQuantity();
            PreparePoweder(grams);
            SelectMold(toy);
            InjectPowder(grams);
            var heatingTime = toy.GetHetingTime();
            HeatMold(heatingTime);
            ExtractToy();
            var color = toy.GetColor();
            PaintToy(color);
        }

        private void PaintToy(Color color)
        {
            Console.WriteLine($"Adding collor {color.GetType().Name}");
        }




        private void ExtractToy()
        {
            Console.WriteLine("Extracting the toy");
        }

        private void HeatMold(TimeSpan heatingTime)
        {
            Console.WriteLine($"heating for {heatingTime.TotalSeconds}");
        }

        private void InjectPowder(int grams)
        {
            Console.WriteLine($"Adding {grams} grams of powder");
        }

        private void SelectMold(Toy toy)
        {
            Console.WriteLine($"Selecting mold {toy.GetType().Name}");
        }

        private void PreparePoweder(int grams)
        {
            Console.WriteLine($"Preparing {grams} grams of powder");
        }
    }
}
