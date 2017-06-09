using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CatalogModel.Codelists
{
	public class WasherType : ICodelist
	{
		public WasherType()
		{
		}

		public WasherType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }
		public int CodelistNumber { get; set; }

		[StringLength(50, ErrorMessage = "Short Description cannot be longer than 50 characters.")]
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int? SortOrder { get; set; }

		public string Name { get; } = "WasherType";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			get
			{
				return null;
			}
		}
	}
}
