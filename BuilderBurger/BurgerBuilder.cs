using WindowsFormsAppPatternBuilder.DBCon;

namespace WindowsFormsAppPatternBuilder.BuilderBurger
{

	public class BurgerBuilder: IBurgerBuilder
	{
		private Burgers _burger;
		public BurgerBuilder()
		{
			_burger = new Burgers();
		}
		public IBurgerBuilder AddBacon()
		{
			_burger. Bacon true; 
			return this;
		}
		public IBurgerBuilder AddCheese()
		{
			_burger. Cheese = true;
			return this;
		}
		public IBurgerBuilder AddLetuce()
		{
			_burger. Letuce = true;
			return this;
		}
		public IBurgerBuilder AddPickles()
		{
			_burger. Pickles = true;
			return this;
		}
		public IBurgerBuilder AddTomato()
		{
			_burger. Tomato = true; 
			return this;
		}
		public Burgers GetBurgers()
		{
			Burgers burger = _burger; _burger = new Burgers(); 
			return burger;
		}
	}
}
