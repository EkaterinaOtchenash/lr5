namespace WindowsFormsAppPatternBuilder.BuilderBurger
{

	public partial class Burgers
	{
		public int ID { get; set; }
		public bool? Cheese { get; set; }
		public bool? Bacon { get; set; }
		public bool? Letuce { get; set; }
		public bool? Tomato { get; set; }
		public bool? Pickles { get; set; }
		public Burgers()
		{
			Cheese = false;
			Bacon = false;
			Letuce = false;
			Tomato = false;
			Pickles = false;
		}
	}
}