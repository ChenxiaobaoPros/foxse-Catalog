using CatalogModel.Codelists;

namespace CatalogModel.Catalog.Commodity
{
	public class PipeStock
    {
		public int ID { get; set; }

		public string IndustryCommodityCode { get; set; }
		public string CommodityType { get; set; }

		public MaterialsGrade MaterialGrade { get; set; }
		public GeometricIndustryStandard GeometricIndustryStandard { get; set; }

		public float Density { get; set; }
		public UnitType DensityUnits { get; set; }
		public bool GraphicalRepresentationOrNot { get; set; }
		public float PurchaseLength { get; set; }
		public UnitType PurchaseLengthUnits { get; set; }
		public float MinimumPipeLength { get; set; }
		public UnitType MinimumPipeLengthUnits { get; set; }
		public float MaximumPipeLength { get; set; }
		public UnitType MaximumPipeLengthUnits { get; set; }
		public ManufacturingMethod ManufacturingMethod { get; set; }
		public SurfacePreparation SurfacePreparation { get; set; }
		public LiningMaterial LiningMaterial { get; set; }

		public float DryWeightForEnd1 { get; set; }
		public UnitType DryWeightForEnd1Units { get; set; }
		public float DryWeightForEnd2 { get; set; }
		public UnitType DryWeightForEnd2Units { get; set; }

		public EndPreparation EndPreparation1 { get; set; }
		public PressureRating PressureRating1 { get; set; }
		public EndStandard EndStandard1 { get; set; }
		public ScheduleThickness ScheduleThickness1 { get; set; }

		public EndPreparation EndPreparation2 { get; set; }
		public PressureRating PressureRating2 { get; set; }
		public EndStandard EndStandard2 { get; set; }
		public ScheduleThickness ScheduleThickness2 { get; set; }

		public int Npd1_Primary { get; set; }
		public UnitType NpdUnitType1 { get; set; }

		public int Npd2_Secondary { get; set; }
		public UnitType NpdUnitType2 { get; set; }

		public float WeightPerUnitLength { get; set; }
		public UnitType WeightPerUnitLengthUnits { get; set; }
		public string PipingNote1 { get; set; }
	}
}
