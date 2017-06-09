using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Piping;

namespace CatalogModel.MaterialClass.Bolts
{
	public class GasketSelectionFilter
	{
		public int ID { get; set; }

		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public int NominalDiameterFrom { get; set; }

		public int NominalDiameterTo { get; set; }

		public UnitType NpdUnitType { get; set; }

		public GasketOption GasketOption { get; set; }

		public float MaximumTemperature { get; set; }
		public UnitType MaximumTemperatureUnits { get; set; }

		public EndPreparation EndPreparation { get; set; }
		public PressureRating PressureRating { get; set; }
		public EndStandard EndStandard { get; set; }
		public EndPreparation AlternateEndPreparation { get; set; }
		public PressureRating AlternatePressureRating { get; set; }
		public EndStandard AlternateEndStandard { get; set; }

		public string ContractorCommodityCode { get; set; }

		public FluidCode FluidCode { get; set; }
		public ScheduleThickness ScheduleThickness { get; set; }

		public int Priority { get; set; }
		public RingNumber RingNumber { get; set; }

		public FabricationType FabricationCategoryOverride { get; set; }
		public SupplyResponsibility SupplyResponsibilityOverride { get; set; }

		public string Comments { get; set; }
		public int QuantityOfAltReportableParts { get; set; }
		public string AltReportableCommodityCode { get; set; }
		public int QuantityOfReportableParts { get; set; }
		public string ReportableCommodityCode { get; set; }

		public string PipingNote1 { get; set; }
	}
}
