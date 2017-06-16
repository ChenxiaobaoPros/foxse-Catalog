using CatalogModel.Specification;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Выбор: отвод/гиб трубы
	/// </summary>
	public class DefaultChangeOfDirectionPerSpec
    {
		public int ID { get; set; }
		public virtual PipingMaterialsClassData SpecName { get; set; }

		public float BendAngleFrom { get; set; }
		public float BendAngleTo { get; set; }

		public virtual UnitType BendAngleFromUnitType { get; set; }
		public virtual UnitType BendAngleToUnitType { get; set; }

		public virtual ShortCodeHierarchyRule FunctionalShortCode { get; set; }
	}
}
