using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// Способ вывода в отчет
	/// </summary>
	public class ReportingType : ICodelist
	{
		public ReportingType()
		{
		}

		public ReportingType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ReportingRequirement ReportingRequirement { get; set; }

		public string Name { get; } = "ReportingType";

		public ICodelist Parent
		{
			get
			{
				return ReportingRequirement;
			}

			set
			{
				ReportingRequirement = (ReportingRequirement)value;
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

	/// <summary>
	/// Выводить или нет в отчет
	/// </summary>
	public class ReportingRequirement : ICodelist, ICodelistCategory
	{
		public ReportingRequirement()
		{
		}

		public ReportingRequirement(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ReportingType> ReportingTypes { get; set; }

		public string Name { get; } = "ReportingRequirement";

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
				return ReportingTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ReportingTypes == null)
				ReportingTypes = new List<ReportingType>();
			ReportingTypes.Add((ReportingType)child);
		}
	}
}
