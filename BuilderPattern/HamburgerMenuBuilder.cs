namespace BuilderPattern
{
    public class HamburgerMenuBuilder : MenuBuilder
    {
        
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
           _menu.Add("Burger 100gr");
        }

        public override void BuildFries()
        {
            _menu.Add("Fries G");
        }

        public override void BuildDesert()
        {
            _menu.Add("Pudim");
        }

        public override void BuildDrink()
        {
            _menu.Add("Coke");
        }

        public override void BuildToy()
        {
            _menu.Add("Toy Story");
        }

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}