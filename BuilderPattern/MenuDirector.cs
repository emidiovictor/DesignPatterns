namespace BuilderPattern
{
    public class MenuDirector
    {
        public void Construct(MenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDesert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}