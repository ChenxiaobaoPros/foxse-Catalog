using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class PressureRating : ICodelist
	{
		public PressureRating()
		{
		}

		public PressureRating(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }

		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }

		public virtual RatingPractice RatingPractice { get; set; }

		public string Name { get; } = "PressureRating";

		public ICodelist Parent
		{
			get
			{
				return RatingPractice;
			}

			set
			{
				RatingPractice = (RatingPractice)value;
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

	public class RatingPractice : ICodelist, ICodelistCategory
	{
		public RatingPractice()
		{
		}

		public RatingPractice(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }

		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }

		public virtual List<PressureRating> PressureRatings { get; set; }

		public string Name { get; } = "RatingPractice";

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
				return PressureRatings.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (PressureRatings == null)
				PressureRatings = new List<PressureRating>();
			PressureRatings.Add((PressureRating)child);
		}
	}
}
