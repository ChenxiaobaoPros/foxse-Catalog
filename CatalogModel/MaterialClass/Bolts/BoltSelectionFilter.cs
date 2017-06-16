using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Piping;
using CatalogModel.Specification;

namespace CatalogModel.MaterialClass.Bolts
{
	public class BoltSelectionFilter
    {
		public int ID { get; set; }
		public virtual PipingMaterialsClassData SpecName { get; set; }

		public int NominalDiameterFrom { get; set; }
		public int NominalDiameterTo { get; set; }
		public virtual UnitType NpdUnitType { get; set; }

		public virtual BoltOption BoltOption { get; set; }

		public float MaximumTemperature { get; set; }
		public virtual UnitType MaximumTemperatureUnits { get; set; }

		public virtual EndPreparation EndPreparation { get; set; }
		public virtual PressureRating PressureRating { get; set; }
		public virtual EndStandard EndStandard { get; set; }
		public virtual EndPreparation AlternateEndPreparation { get; set; }
		public virtual PressureRating AlternateEndStandard { get; set; }

		public virtual PipingCommodityMatlControlData ContractorCommodityCode { get; set; }

		public int Priority { get; set; }
		public virtual BoltExtensionOption BoltExtensionOption { get; set; }

		public virtual FabricationType FabricationCategoryOverride { get; set; }
		public virtual SupplyResponsibility SupplyResponsibilityOverride { get; set; }

		public string Comments { get; set; }
		public string PipingNote1 { get; set; }

		public virtual BoltLubricationRequirements LubricationRequirements { get; set; }
	}
}
