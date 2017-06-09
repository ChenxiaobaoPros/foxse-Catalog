using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class Examination : ICodelist
	{
		public Examination()
		{
		}

		public Examination(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ExaminationPractice ExaminationPractice { get; set; }

		public string Name { get; } = "Examination";

		public ICodelist Parent
		{
			get { return ExaminationPractice; }
			set { ExaminationPractice = (ExaminationPractice)value; }
		}

		public List<ICodelist> Childs
		{
			get { return null; }
		}
	}

	public class ExaminationPractice : ICodelist, ICodelistCategory
	{
		public ExaminationPractice()
		{
		}

		public ExaminationPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<Examination> Examinations { get; set; }

		public string Name { get; } = "ExaminationPractice";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get { return Examinations.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (Examinations == null)
				Examinations = new List<Examination>();
			Examinations.Add((Examination)child);
		}
	}
}
