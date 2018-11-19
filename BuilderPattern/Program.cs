using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var director = new MenuDirector();
            
            
            var builder1 = new SaladMenuBuilder();
            director.Construct(builder: builder1);
            var menu = builder1.GetResult();
            Console.WriteLine("Salad Menu: {0}", menu);
            
            
            var builder2 = new HamburgerMenuBuilder();
            director.Construct(builder2);
            menu = builder2.GetResult();
            Console.WriteLine("Hamburger Menu: {0}", menu);
        }
    }
}