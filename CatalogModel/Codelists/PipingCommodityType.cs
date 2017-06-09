using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class PipingCommodityType : ICodelist
	{
		public PipingCommodityType()
		{
		}

		public PipingCommodityType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual PipingCommoditySubClass PipingCommoditySubClass { get; set; }

		public string Name { get; } = "PipingCommodityType";

		public ICodelist Parent
		{
			get
			{
				return PipingCommoditySubClass;
			}

			set
			{
				PipingCommoditySubClass = (PipingCommoditySubClass)value;
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

	public class PipingCommoditySubClass : ICodelist, ICodelistCategory
	{
		public PipingCommoditySubClass()
		{
		}

		public PipingCommoditySubClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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
		public string Name { get; } = "PipingCommoditySubClass";

		public virtual PipingCommodityClass PipingCommodityClass { get; set; }
		public virtual List<PipingCommodityType> PipingCommodityTypes { get; set; }

		public ICodelist Parent
		{
			get
			{
				return PipingCommodityClass;
			}

			set
			{
				PipingCommodityClass = (PipingCommodityClass)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return PipingCommodityTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (PipingCommodityTypes == null)
				PipingCommodityTypes = new List<PipingCommodityType>();
			PipingCommodityTypes.Add((PipingCommodityType)child);
		}
	}

	public class PipingCommodityClass : ICodelist, ICodelistCategory
	{
		public PipingCommodityClass()
		{
		}

		public PipingCommodityClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<PipingCommoditySubClass> PipingCommoditySubClasses { get; set; }

		public string Name { get; } = "PipingCommodityClass";

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
				return PipingCommoditySubClasses.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (PipingCommoditySubClasses == null)
				PipingCommoditySubClasses = new List<PipingCommoditySubClass>();
			PipingCommoditySubClasses.Add((PipingCommoditySubClass)child);
		}
	}
}
