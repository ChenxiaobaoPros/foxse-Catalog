using System;
using System.Collections.Generic;

namespace CatalogModel
{
	public interface ICodelist
	{
		int ID { get; }
		int CodelistNumber { get; set; }
		string ShortDescription { get; set; }
		string LongDescription { get; set; }
		int? SortOrder { get; set; }

		ICodelist Parent { get; set; }
		List<ICodelist> Childs { get; }
		string Name { get; }
	}
}
