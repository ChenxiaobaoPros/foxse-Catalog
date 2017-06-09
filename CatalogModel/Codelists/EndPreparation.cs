using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class EndPreparation : ICodelist
    {
		public EndPreparation()
		{
		}

		public EndPreparation(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual TerminationSubClass TerminationSubClass { get; set; }

		public string Name { get; } = "EndPreparation";

		public ICodelist Parent
		{
			get
			{
				return TerminationSubClass;
			}

			set
			{
				TerminationSubClass = (TerminationSubClass)value;
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

	public class TerminationSubClass : ICodelist, ICodelistCategory
	{
		public TerminationSubClass()
		{
		}

		public TerminationSubClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual TerminationClass TerminationClass { get; set; }

		public virtual List<EndPreparation> EndPreparations { get; set; }

		public string Name { get; } = "TerminationSubClass";

		public ICodelist Parent
		{
			get
			{
				return TerminationClass;
			}

			set
			{
				TerminationClass = (TerminationClass)value;
			}
		}

		public List<ICodelist> Childs
		{
			get
			{
				return EndPreparations.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (EndPreparations == null)
				EndPreparations = new List<EndPreparation>();
			EndPreparations.Add((EndPreparation)child);
		}
	}

	public class TerminationClass : ICodelist, ICodelistCategory
	{
		public TerminationClass()
		{
		}

		public TerminationClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<TerminationSubClass> TerminationSubClasses { get; set; }

		public string Name { get; } = "TerminationClass";

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
				return TerminationSubClasses.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (TerminationSubClasses == null)
				TerminationSubClasses = new List<TerminationSubClass>();
			TerminationSubClasses.Add((TerminationSubClass)child);
		}
	}

}
