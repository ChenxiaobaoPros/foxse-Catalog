using CatalogModel.Specification;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Выбор: отвод/гиб трубы
	/// </summary>
	public class DefaultChangeOfDirectionPerSpec
    {
		public int ID { get; set; }
		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public float BendAngleFrom { get; set; }
		public float BendAngleTo { get; set; }

		public UnitType BendAngleFromUnitType { get; set; }
		public UnitType BendAngleToUnitType { get; set; }

		public ShortCodeHierarchyRule FunctionalShortCode { get; set; }
	}
}
