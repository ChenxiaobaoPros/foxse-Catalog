using System;
using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class CoatingType : ICodelist
	{
		public CoatingType()
		{
		}

		public CoatingType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual CoatingRequirement CoatingRequirement { get; set; }

		public string Name { get; } = "CoatingType";

		public ICodelist Parent
		{
			get
			{
				return CoatingRequirement;
			}

			set
			{
				CoatingRequirement = (CoatingRequirement)value;
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
			get { return "CoatingRequirement"; }
		}
	}

	public class CoatingRequirement : ICodelist, ICodelistCategory
	{
		public CoatingRequirement()
		{
		}

		public CoatingRequirement(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<CoatingType> CoatingTypes { get; set; }

		public string Name { get; } = "CoatingRequirement";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get
			{
				return CoatingTypes.ToList<ICodelist>();
			}
		}

		public Type ParentType
		{
			get { return null; }
		}

		public void AddChild(ICodelist child)
		{
			if (CoatingTypes == null)
				CoatingTypes = new List<CoatingType>();
			CoatingTypes.Add((CoatingType)child);
		}
	}
}
