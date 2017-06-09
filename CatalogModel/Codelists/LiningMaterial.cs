using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class LiningMaterial : ICodelist
	{
		public LiningMaterial()
		{
		}

		public LiningMaterial(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual LiningRequirements LiningRequirements { get; set; }

		public string Name { get; } = "LiningMaterial";

		public ICodelist Parent
		{
			get { return LiningRequirements; }
			set { LiningRequirements = (LiningRequirements)value; }
		}

		public List<ICodelist> Childs
		{
			get { return null; }
		}
	}

	public class LiningRequirements : ICodelist, ICodelistCategory
	{
		public LiningRequirements()
		{
		}

		public LiningRequirements(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<LiningMaterial> LiningMaterials { get; set; }

		public string Name { get; } = "LiningRequirements";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get { return LiningMaterials.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (LiningMaterials == null)
				LiningMaterials = new List<LiningMaterial>();
			LiningMaterials.Add((LiningMaterial)child);
		}
	}
}
