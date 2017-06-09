using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// Перечень производителей
	/// </summary>
	public class Manufacturer : ICodelist
	{
		public Manufacturer()
		{
		}

		public Manufacturer(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ManufacturerIndustryPractice ManufacturerIndustryPractice { get; set; }

		public string Name { get; } = "Manufacturer";

		public ICodelist Parent
		{
			get
			{
				return ManufacturerIndustryPractice;
			}

			set
			{
				ManufacturerIndustryPractice = (ManufacturerIndustryPractice)value;
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

	/// <summary>
	/// Перечень стран - производителей
	/// </summary>
	public class ManufacturerIndustryPractice : ICodelist, ICodelistCategory
	{
		public ManufacturerIndustryPractice()
		{
		}

		public ManufacturerIndustryPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<Manufacturer> Manufacturers { get; set; }

		public string Name { get; } = "ManufacturerIndustryPractice";

		public ICodelist Parent
		{
			get
			{
				return null;
			}

			set
			{

			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return Manufacturers.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (Manufacturers == null)
				Manufacturers = new List<Manufacturer>();
			Manufacturers.Add((Manufacturer)child);
		}
	}
}