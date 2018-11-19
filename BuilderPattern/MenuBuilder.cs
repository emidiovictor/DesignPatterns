namespace BuilderPattern
{
    public abstract class MenuBuilder
    {
        public abstract void BuildBurgerOrSalad();

        public abstract void BuildFries();

        public abstract void BuildDesert();
  
        public abstract void BuildDrink();
    
        public abstract void BuildToy();


        public abstract Menu GetResult();



    }
}