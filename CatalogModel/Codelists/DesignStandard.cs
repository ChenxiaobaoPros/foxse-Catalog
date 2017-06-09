using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class DesignStandard : ICodelist
	{
		public DesignStandard()
		{
		}

		public DesignStandard(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual DesignStandardPractice DesignStandardPractice { get; set; }

		public string Name { get; } = "DesignStandard";

		public ICodelist Parent
		{
			get
			{
				return DesignStandardPractice;
			}

			set
			{
				DesignStandardPractice = (DesignStandardPractice)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return null;
			}
		}

		public string ParentType
		{
			get { return "DesignStandardPractice"; }
		}
	}

	public class DesignStandardPractice : ICodelist, ICodelistCategory
	{
		public DesignStandardPractice()
		{
		}

		public DesignStandardPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<DesignStandard> DesignStandards { get; set; }

		public string Name { get; } = "DesignStandardPractice";

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
				return DesignStandards.ToList<ICodelist>();
			}
		}

		public string ParentType
		{
			get { return null; }
		}

		public void AddChild(ICodelist child)
		{
			if (DesignStandards == null)
				DesignStandards = new List<DesignStandard>();
			DesignStandards.Add((DesignStandard)child);
		}
	}
}
