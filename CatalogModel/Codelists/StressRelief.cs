using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class StressRelief : ICodelist
	{
		public StressRelief()
		{
		}

		public StressRelief(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual StressReliefPractice StressReliefPractice { get; set; }

		public string Name { get; } = "StressRelief";

		public ICodelist Parent
		{
			get
			{
				return StressReliefPractice;
			}

			set
			{
				StressReliefPractice = (StressReliefPractice)value;
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

	public class StressReliefPractice : ICodelist, ICodelistCategory
	{
		public StressReliefPractice()
		{
		}

		public StressReliefPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<StressRelief> StressReliefs { get; set; }


		public string Name { get; } = "StressReliefPractice";

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
				return StressReliefs.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (StressReliefs == null)
				StressReliefs = new List<StressRelief>();
			StressReliefs.Add((StressRelief)child);
		}
	}
}
