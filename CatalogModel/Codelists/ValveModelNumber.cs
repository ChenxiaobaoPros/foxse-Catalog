using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class ValveModelNumber : ICodelist
	{
		public ValveModelNumber()
		{
		}

		public ValveModelNumber(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ValveManufacturer ValveManufacturer { get; set; }

		public string Name { get; } = "ValveModelNumber";

		public ICodelist Parent
		{
			get
			{
				return ValveManufacturer;
			}

			set
			{
				ValveManufacturer = (ValveManufacturer)value;
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

	public class ValveManufacturer : ICodelist, ICodelistCategory
	{
		public ValveManufacturer()
		{
		}

		public ValveManufacturer(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ValveManufacturerIndPractice ValveManufacturerIndPractice { get; set; }
		public virtual List<ValveModelNumber> ValveModelNumbers { get; set; }

		public string Name { get; } = "ValveManufacturer";

		public ICodelist Parent
		{
			get
			{
				return ValveManufacturerIndPractice;
			}

			set
			{
				ValveManufacturerIndPractice = (ValveManufacturerIndPractice)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return ValveModelNumbers.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ValveModelNumbers == null)
				ValveModelNumbers = new List<ValveModelNumber>();
			ValveModelNumbers.Add((ValveModelNumber)child);
		}
	}

	public class ValveManufacturerIndPractice : ICodelist, ICodelistCategory
	{
		public ValveManufacturerIndPractice()
		{
		}

		public ValveManufacturerIndPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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


		public virtual List<ValveManufacturer> ValveManufacturers { get; set; }

		public string Name { get; } = "ValveManufacturerIndPractice";

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
				return ValveManufacturers.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ValveManufacturers == null)
				ValveManufacturers = new List<ValveManufacturer>();
			ValveManufacturers.Add((ValveManufacturer)child);
		}
	}
}
