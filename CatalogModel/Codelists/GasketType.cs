using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class GasketType : ICodelist
	{
		public GasketType()
		{
		}

		public GasketType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }

		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int? SortOrder { get; set; }

		public virtual GasketCategory GasketCategory { get; set; }

		public string Name { get; } = "GasketType";

		public ICodelist Parent
		{
			get { return GasketCategory; }
			set { GasketCategory = (GasketCategory)value; }
		}

		public List<ICodelist> Childs
		{
			get { return null; }
		}
	}

	public class GasketCategory : ICodelist, ICodelistCategory
	{
		public GasketCategory()
		{
		}

		public GasketCategory(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }

		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int? SortOrder { get; set; }

		public virtual List<GasketType> GasketTypes { get; set; }

		public string Name { get; } = "GasketCategory";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get { return GasketTypes.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (GasketTypes == null)
				GasketTypes = new List<GasketType>();
			GasketTypes.Add((GasketType)child);
		}
	}
}
