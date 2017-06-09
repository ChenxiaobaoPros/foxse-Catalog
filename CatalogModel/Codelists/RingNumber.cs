using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class RingNumber : ICodelist
	{
		public RingNumber()
		{
		}

		public RingNumber(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual RingNumberPractice RingNumberPractice { get; set; }

		public string Name { get; } = "RingNumber";

		public ICodelist Parent
		{
			get
			{
				return RingNumberPractice;
			}

			set
			{
				RingNumberPractice = (RingNumberPractice)value;
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

	public class RingNumberPractice : ICodelist, ICodelistCategory
	{
		public RingNumberPractice()
		{
		}

		public RingNumberPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<RingNumber> RingNumbers { get; set; }

		public string Name { get; } = "RingNumberPractice";

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
				return RingNumbers.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (RingNumbers == null)
				RingNumbers = new List<RingNumber>();
			RingNumbers.Add((RingNumber)child);
		}
	}
}
