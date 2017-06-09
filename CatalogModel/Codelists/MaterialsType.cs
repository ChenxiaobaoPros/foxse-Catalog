using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class MaterialsType : ICodelist
	{
		public MaterialsType()
		{
		}

		public MaterialsType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual MaterialsGroup MaterialsGroup { get; set; }

		public string Name { get; } = "MaterialsType";

		public ICodelist Parent
		{
			get
			{
				return MaterialsGroup;
			}

			set
			{
				MaterialsGroup = (MaterialsGroup)value;
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

	public class MaterialsGroup : ICodelist, ICodelistCategory
	{
		public MaterialsGroup()
		{
		}

		public MaterialsGroup(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<MaterialsType> MaterialsTypes { get; set; }

		public string Name { get; } = "MaterialsGroup";

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
				return MaterialsTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (MaterialsTypes == null)
				MaterialsTypes = new List<MaterialsType>();
			MaterialsTypes.Add((MaterialsType)child);
		}
	}
}
