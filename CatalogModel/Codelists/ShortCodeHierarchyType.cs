using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class ShortCodeHierarchyType : ICodelist
	{
		public ShortCodeHierarchyType()
		{
		}

		public ShortCodeHierarchyType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ShortCodeHierarchyClass ShortCodeHierarchyClass { get; set; }

		public string Name { get; } = "ShortCodeHierarchyType";

		public ICodelist Parent
		{
			get
			{
				return ShortCodeHierarchyClass;
			}

			set
			{
				ShortCodeHierarchyClass = (ShortCodeHierarchyClass)value;
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


	public class ShortCodeHierarchyClass : ICodelist, ICodelistCategory
	{
		public ShortCodeHierarchyClass()
		{
		}

		public ShortCodeHierarchyClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ShortCodeHierarchyType> ShortCodeHierarchyTypes { get; set; }

		public string Name { get; } = "ShortCodeHierarchyClass";

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
				return ShortCodeHierarchyTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ShortCodeHierarchyTypes == null)
				ShortCodeHierarchyTypes = new List<ShortCodeHierarchyType>();
			ShortCodeHierarchyTypes.Add((ShortCodeHierarchyType)child);
		}
	}
}