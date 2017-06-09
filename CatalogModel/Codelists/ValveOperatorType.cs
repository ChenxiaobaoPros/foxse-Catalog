using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class ValveOperatorType : ICodelist
	{
		public ValveOperatorType()
		{
		}

		public ValveOperatorType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ValveOperatorClass ValveOperatorClass { get; set; }

		public string Name { get; } = "ValveOperatorType";

		public ICodelist Parent
		{
			get
			{
				return ValveOperatorClass;
			}

			set
			{
				ValveOperatorClass = (ValveOperatorClass)value;
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

	public class ValveOperatorClass : ICodelist, ICodelistCategory
	{
		public ValveOperatorClass()
		{
		}

		public ValveOperatorClass(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ValveOperatorType> ValveOperatorTypes { get; set; }

		public string Name { get; } = "ValveOperatorClass";

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
				return ValveOperatorTypes.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ValveOperatorTypes == null)
				ValveOperatorTypes = new List<ValveOperatorType>();
			ValveOperatorTypes.Add((ValveOperatorType)child);
		}
	}
}
