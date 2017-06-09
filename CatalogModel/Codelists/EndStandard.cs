using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class EndStandard : ICodelist
	{
		public EndStandard()
		{
		}

		public EndStandard(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual EndPractice EndPractice { get; set; }

		public string Name { get; } = "EndStandard";

		public ICodelist Parent
		{
			get { return EndPractice; }
			set { EndPractice = (EndPractice)value; }
		}

		public List<ICodelist> Childs
		{
			get { return null; }
		}
	}

	public class EndPractice : ICodelist, ICodelistCategory
	{
		public EndPractice()
		{
		}

		public EndPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<EndStandard> EndStandards { get; set; }

		public string Name { get; } = "EndPractice";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get { return EndStandards.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (EndStandards == null)
				EndStandards = new List<EndStandard>();
			EndStandards.Add((EndStandard)child);
		}
	}
}
