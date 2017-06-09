using System.Collections.Generic;
using System.Linq;

namespace CatalogModel.Codelists
{
	public class MiscRequisitionClassification : ICodelist
	{
		public MiscRequisitionClassification()
		{
		}

		public MiscRequisitionClassification(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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
		public virtual MiscRequisitionComponentType MiscRequisitionComponentType { get; set; }
		public string Name { get; } = "MiscRequisitionClassification";

		public ICodelist Parent
		{
			get
			{
				return MiscRequisitionComponentType;
			}

			set
			{
				MiscRequisitionComponentType = (MiscRequisitionComponentType)value;
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

	public class MiscRequisitionComponentType : ICodelist, ICodelistCategory
	{
		public MiscRequisitionComponentType()
		{
		}

		public MiscRequisitionComponentType(string codelistNumber, string shortDescription, string longDescription, string sortOrder)
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

		public virtual List<MiscRequisitionClassification> MiscRequisitionClassifications { get; set; }
		public string Name { get; } = "MiscRequisitionComponentType";

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
				return MiscRequisitionClassifications.ToList<ICodelist>();
			}
		}

		public void AddChild(ICodelist child)
		{
			if (MiscRequisitionClassifications == null)
				MiscRequisitionClassifications = new List<MiscRequisitionClassification>();
			MiscRequisitionClassifications.Add((MiscRequisitionClassification)child);
		}
	}
}
