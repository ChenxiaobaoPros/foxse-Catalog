using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	/// <summary>
	/// Код среды
	/// </summary>
	public class FluidCode : ICodelist
	{
		public FluidCode()
		{
		}

		public FluidCode(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }

		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }

		public virtual FluidSystem FluidSystem { get; set; }

		public string Name { get; } = "FluidCode";

		public ICodelist Parent
		{
			get { return FluidSystem; }
			set { FluidSystem = (FluidSystem)value; }
		}

		public List<ICodelist> Childs
		{
			get { return null; }
		}
	}

	/// <summary>
	/// Система среды
	/// </summary>
	public class FluidSystem : ICodelist, ICodelistCategory
	{
		public FluidSystem()
		{
		}

		public FluidSystem(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
		{
			CodelistNumber = int.Parse(codelistNumber);
			ShortDescription = shortDescription;
			LongDescription = longDescription;
			SortOrder = int.Parse(sortOrder);
		}

		public int ID { get; set; }

		public int CodelistNumber { get; set; }
		public int? SortOrder { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }

		public virtual List<FluidCode> FluidCodes { get; set; }

		public string Name { get; } = "FluidSystem";

		public ICodelist Parent
		{
			get { return null; }
			set { }
		}

		public List<ICodelist> Childs
		{
			set { }
			get { return FluidCodes.ToList<ICodelist>(); }
		}

		public void AddChild(ICodelist child)
		{
			if (FluidCodes == null)
				FluidCodes = new List<FluidCode>();
			FluidCodes.Add((FluidCode)child);
		}
	}
}
