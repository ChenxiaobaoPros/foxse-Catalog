using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class MaterialsGrade : ICodelist
	{
		public MaterialsGrade()
		{
		}

		public MaterialsGrade(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual MaterialsCategory MaterialsCategory { get; set; }

		public string Name { get; } = "MaterialsGrade";

		public ICodelist Parent
		{
			get
			{
				return MaterialsCategory;
			}

			set
			{
				MaterialsCategory = (MaterialsCategory)value;
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

	public class MaterialsCategory : ICodelist, ICodelistCategory
	{
		public MaterialsCategory()
		{
		}

		public MaterialsCategory(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<MaterialsGrade> MaterialsGrades { get; set; }
		public virtual MaterialsGradePractice MaterialsGradePractice { get; set; }

		public string Name { get; } = "MaterialsCategory";

		public ICodelist Parent
		{
			get
			{
				return MaterialsGradePractice;
			}

			set
			{
				MaterialsGradePractice = (MaterialsGradePractice)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return MaterialsGrades.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (MaterialsGrades == null)
				MaterialsGrades = new List<MaterialsGrade>();
			MaterialsGrades.Add((MaterialsGrade)child);
		}
	}

	public class MaterialsGradePractice : ICodelist, ICodelistCategory
	{
		public MaterialsGradePractice()
		{
		}

		public MaterialsGradePractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<MaterialsCategory> MaterialsCategories { get; set; }

		public string Name { get; } = "MaterialsGradePractice";

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
				return MaterialsCategories.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (MaterialsCategories == null)
				MaterialsCategories = new List<MaterialsCategory>();
			MaterialsCategories.Add((MaterialsCategory)child);
		}
	}
}
