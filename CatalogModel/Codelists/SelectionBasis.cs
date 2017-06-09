using System.Collections.Generic;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// Как правильно отрисовывается деталь (системная таблица)
	/// This is a system code list. The user may change the textual value, but must not change the numeric value or the meaning of the value; and the user must not add or delete a value.
	/// </summary>
	public class SelectionBasis : ICodelist
	{
		public SelectionBasis()
		{
		}

		public SelectionBasis(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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
		public string Name { get; } = "SelectionBasis";

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
				return null;
			}
		}
	}
}
