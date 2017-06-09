using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{

	/// <summary>
	/// Геометр. стандарт на привод
	/// </summary>
	public class ValveOperatorGeometricIndStd : ICodelist
	{
		public ValveOperatorGeometricIndStd()
		{
		}

		public ValveOperatorGeometricIndStd(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual ValveOperatorGeometricIndPract ValveOperatorGeometricIndPract { get; set; }


		public string Name { get; } = "ValveOperatorGeometricIndStd";

		public ICodelist Parent
		{
			get
			{
				return ValveOperatorGeometricIndPract;
			}

			set
			{
				ValveOperatorGeometricIndPract = (ValveOperatorGeometricIndPract)value;
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
	/// Страна - изготовитель
	/// </summary>
	public class ValveOperatorGeometricIndPract : ICodelist, ICodelistCategory
	{
		public ValveOperatorGeometricIndPract()
		{
		}

		public ValveOperatorGeometricIndPract(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<ValveOperatorGeometricIndStd> ValveOperatorGeometricIndStds { get; set; }

		public string Name { get; } = "ValveOperatorGeometricIndPract";

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
				return ValveOperatorGeometricIndStds.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (ValveOperatorGeometricIndStds == null)
				ValveOperatorGeometricIndStds = new List<ValveOperatorGeometricIndStd>();
			ValveOperatorGeometricIndStds.Add((ValveOperatorGeometricIndStd)child);
		}
	}
}
