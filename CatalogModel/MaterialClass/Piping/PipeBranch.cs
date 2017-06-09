using CatalogModel.Specification;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Таблица врезок
	/// </summary>
	public class PipeBranch
    {
		public int ID { get; set; }
		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public int HeaderSize { get; set; }
		public int BranchSize { get; set; }
		public float AngleLow { get; set; }
		public float AngleHigh { get; set; }

		public UnitType AngleLowUnitType { get; set; }
		public UnitType AngleHighUnitType { get; set; }
		public UnitType HdrSizeNPDUnitType { get; set; }
		public UnitType BrSizeNPDUnitType { get; set; }

		public ShortCodeHierarchyRule ShortCode { get; set; }
		public ShortCodeHierarchyRule SecondaryShortCode { get; set; }
		public ShortCodeHierarchyRule TertiaryShortCode { get; set; }

			
	}
}
