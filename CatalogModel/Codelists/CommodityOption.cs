using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// OptionCodes.
	/// (The numeric value for any new code list entry added by the user should be between 10,001 and 40,000. SmartPlant would reserve all other numeric values.)
	/// </summary>
	public class CommodityOption : ICodelist
	{
		public CommodityOption()
		{
		}

		public CommodityOption(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }

		public string ShortDescription { get; set; }

		public int? SortOrder { get; set; }

		public string LongDescription { get; set; }

		public virtual OptionCategory OptionCategory { get; set; }

		public string Name { get; } = "CommodityOption";

		public ICodelist Parent
		{
			get
			{
				return OptionCategory;
			}

			set
			{
				OptionCategory = (OptionCategory)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return null;
			}
		}
	}

	public class OptionCategory : ICodelist, ICodelistCategory
	{
		public OptionCategory()
		{
		}

		public OptionCategory(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<CommodityOption> CommodityOptions { get; set; }

		public string Name { get; } = "OptionCategory";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get
			{
				return CommodityOptions.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (CommodityOptions == null)
				CommodityOptions = new List<CommodityOption>();
			CommodityOptions.Add((CommodityOption)child);
		}
	}
}
