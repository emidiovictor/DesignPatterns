namespace BuilderPattern
{
    public class SaladMenuBuilder : MenuBuilder
    {
        
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
            _menu.Add("Salad");
        }

        public override void BuildFries()
        {
        }

        public override void BuildDesert()
        {
        }

        public override void BuildDrink()
        {
            _menu.Add("Orange Juice");
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