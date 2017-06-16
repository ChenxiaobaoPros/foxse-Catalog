namespace CatalogModel
{
	public class UnitType
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public override string ToString()
		{
			return Name;
		}

		public virtual UnitClass UnitClass { get; set; }
	}
}