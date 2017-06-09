using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class ScheduleThickness : ICodelist
	{
		public ScheduleThickness()
		{
		}

		public ScheduleThickness(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ScheduleThicknessPractice ScheduleThicknessPractice { get; set; }

		public string Name { get; } = "ScheduleThickness";

		public ICodelist Parent
		{
			get
			{
				return ScheduleThicknessPractice;
			}

			set
			{
				ScheduleThicknessPractice = (ScheduleThicknessPractice)value;
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

	public class ScheduleThicknessPractice : ICodelist, ICodelistCategory
	{
		public ScheduleThicknessPractice()
		{
		}

		public ScheduleThicknessPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ScheduleThickness> ScheduleThicknesses { get; set; }

		public string Name { get; } = "ScheduleThicknessPractice";

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
				return ScheduleThicknesses.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ScheduleThicknesses == null)
				ScheduleThicknesses = new List<ScheduleThickness>();
			ScheduleThicknesses.Add((ScheduleThickness)child);
		}
	}
}
