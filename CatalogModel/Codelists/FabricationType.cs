using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// Тип изготовления
	/// </summary>
	public class FabricationType : ICodelist
	{
		public FabricationType()
		{
		}

		public FabricationType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }

		public virtual FabricationRequirement FabricationRequirement { get; set; }

		public string Name { get; } = "FabricationType";

		public ICodelist Parent 
		{
			get { return FabricationRequirement; }
			set { FabricationRequirement = (FabricationRequirement)value; }
		}

		public List<ICodelist> Childs	
		{
			get { return null; }
		}
	}

	/// <summary>
	/// Требование к изготовлению
	/// </summary>
	public class FabricationRequirement : ICodelist, ICodelistCategory
	{
		public FabricationRequirement()
		{
		}

		public FabricationRequirement(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		
		public virtual List<FabricationType> FabricationTypes { get; set; }

		public string Name { get; } = "FabricationRequirement";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get { return FabricationTypes.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (FabricationTypes == null)
				FabricationTypes = new List<FabricationType>();
			FabricationTypes.Add((FabricationType)child);
		}
	}

}
