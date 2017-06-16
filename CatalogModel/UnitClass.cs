using System.Collections.Generic;

namespace CatalogModel
{
	public class UnitClass
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public virtual List<UnitType> Units { get; set; }
	}
}