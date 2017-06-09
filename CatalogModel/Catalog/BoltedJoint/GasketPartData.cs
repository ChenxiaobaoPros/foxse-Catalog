using CatalogModel.Codelists;

namespace CatalogModel.Catalog.BoltedJoint
{
	/// <summary>
	/// Прокладки
	/// </summary>
	public class GasketPartData
    {
		public int ID { get; set; }

		public string IndustryCommodityCode { get; set; }
		public RingNumber RingNumber { get; set; }
		public int NominalDiameterFrom { get; set; }
		public int NominalDiameterTo { get; set; }
		public int? NominalDiameter { get; set; }
		public UnitType NpdUnitType { get; set; }
		public GeometricIndustryStandard GasketIndustryStandard { get; set; }
		public GasketType GasketType { get; set; }
		public float ThicknessFor3DModel { get; set; }
		public UnitType ThicknessFor3DModelUnits { get; set; }

		public float ProcurementThickness { get; set; }
		public UnitType ProcurementThicknessUnits { get; set; }

		public MaterialsGrade MaterialsGrade { get; set; }

		public float? GasketOutsideDiameter { get; set; }
		public UnitType GasketOutsideDiameterUnits { get; set; }

		public float? GasketInsideDiameter { get; set; }
		public UnitType GasketInsideDiameterUnits { get; set; }

		public GasketOutsideDiameterBasis GasketOutsideDiameterBasis { get; set; }

		public FlangeInsulationKitType FlangeInsulationKitType { get; set; }

		public float? InsulatingWasherThickness { get; set; }
		public UnitType InsulatingWasherThicknessUnits { get; set; }

		public float? MetallicElectroPlatedWasherThk { get; set; }
		public UnitType MetallicElectroPlatedWasherThkUnits { get; set; }

		public float? MaintenanceFactor { get; set; }

		public float? FlangePressure { get; set; }
		public UnitType FlangePressureUnits { get; set; }

		public bool? StressAtWhichSealIsInitiated { get; set; }

		public float? TightnessCurveSlope { get; set; }
		public UnitType TightnessCurveSlopeUnits { get; set; }

		public bool? IntersectionOfUnloadCurveWithVerticalAxis { get; set; }
		
		public int? MinimumTightnessParameter { get; set; }
		public int? MaximumTightnessParameter { get; set; }

		public float? MaximumTemperature { get; set; }
		public UnitType MaximumTemperatureUnits { get; set; }

		public float? MaximumPressure { get; set; }
		public UnitType MaximumPressureUnits { get; set; }

		public GasketInsideDiameterBasis GasketInsideDiameterBasis { get; set; }
		public FlangeFacing FlangeFacing { get; set; }
		public int? StyleNumber { get; set; }
	}
}
