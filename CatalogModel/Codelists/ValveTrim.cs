using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class ValveTrim : ICodelist
	{
		public ValveTrim()
		{
		}

		public ValveTrim(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ValveTrimPractice ValveTrimPractice { get; set; }

		public string Name { get; } = "ValveTrim";

		public ICodelist Parent
		{
			get
			{
				return ValveTrimPractice;
			}

			set
			{
				ValveTrimPractice = (ValveTrimPractice)value;
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

	public class ValveTrimPractice : ICodelist, ICodelistCategory
	{
		public ValveTrimPractice()
		{
		}

		public ValveTrimPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ValveTrim> ValveTrims { get; set; }

		public string Name { get; } = "ValveTrimPractice";

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
				return ValveTrims.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ValveTrims == null)
				ValveTrims = new List<ValveTrim>();
			ValveTrims.Add((ValveTrim)child);
		}
	}
}
