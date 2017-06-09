using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Piping;

namespace CatalogModel.MaterialClass.Bolts
{
	public class BoltSelectionFilter
    {
		public int ID { get; set; }
		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public int NominalDiameterFrom { get; set; }
		public int NominalDiameterTo { get; set; }
		public UnitType NpdUnitType { get; set; }

		public BoltOption BoltOption { get; set; }

		public float MaximumTemperature { get; set; }
		public UnitType MaximumTemperatureUnits { get; set; }

		public EndPreparation EndPreparation { get; set; }
		public PressureRating PressureRating { get; set; }
		public EndStandard EndStandard { get; set; }
		public EndPreparation AlternateEndPreparation { get; set; }
		public PressureRating AlternateEndStandard { get; set; }

		public string ContractorCommodityCode { get; set; }

		public int Priority { get; set; }
		public BoltExtensionOption BoltExtensionOption { get; set; }

		public FabricationType FabricationCategoryOverride { get; set; }
		public SupplyResponsibility SupplyResponsibilityOverride { get; set; }

		public string Comments { get; set; }
		public string PipingNote1 { get; set; }

		public BoltLubricationRequirements LubricationRequirements { get; set; }
	}
}
