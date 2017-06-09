﻿using System;
using System.Collections.Generic;

namespace CatalogModel.Codelists
{
	public class AutomatedFlangeSelectionOption : ICodelist
    {
		public AutomatedFlangeSelectionOption()
		{
		}

		public AutomatedFlangeSelectionOption(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public string Name { get; } = "AutomatedFlangeSelectionOption";

		public ICodelist Parent
		{
			get	{return null;}
			set	{}
		}

		public List<ICodelist> Childs
		{
			get	{return null;}
		}

		public string ParentType
		{
			get { return null; }
		}
	}
}
