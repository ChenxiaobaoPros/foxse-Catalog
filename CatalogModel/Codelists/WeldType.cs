using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class WeldType : ICodelist
	{
		public WeldType()
		{
		}

		public WeldType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual WeldClass WeldClass { get; set; }

		public string Name { get; } = "WeldType";

		public ICodelist Parent
		{
			get
			{
				return WeldClass;
			}

			set
			{
				WeldClass = (WeldClass)value;
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

	public class WeldClass : ICodelist, ICodelistCategory
	{
		public WeldClass()
		{
		}

		public WeldClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<WeldType> WeldTypes { get; set; }

		public string Name { get; } = "WeldClass";

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
				return WeldTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (WeldTypes == null)
				WeldTypes = new List<WeldType>();
			WeldTypes.Add((WeldType)child);
		}
	}
}
