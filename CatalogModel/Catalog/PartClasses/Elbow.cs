using CatalogModel.Codelists;

namespace CatalogModel.Catalog.PartClasses
{
	/// <summary>
	/// Отвод
	/// </summary>
	public class Elbow
	{
		public int ID { get; set; }
		public string IndustryCommodityCode { get; set; }
		public PipingCommodityType CommodityType { get; set; }
		public GeometryType GeometryType { get; set; }
		public bool? GraphicalRepresentationOrNot { get; set; }
		public string SymbolDefinition { get; set; }

		public string SymbolIcon { get; set; }
		public MaterialsGrade MaterialGrade { get; set; }
		public LiningMaterial LiningMaterial { get; set; }

		public float? BendAngle { get; set; }
		public UnitType BendAngleUnits { get; set; }
		public float? BendRadius { get; set; }
		public UnitType BendRadiusUnits { get; set; }
		public float? BendRadiusMultiplier { get; set; }
		public MirrorBehaviorOption MirrorBehaviorOption { get; set; }
		public GeometricIndustryStandard GeometricIndustryStandard { get; set; }
		public PartDataBasis PartDataBasis { get; set; }

		public ValveManufacturer ValveManufacturer { get; set; }
		public ValveModelNumber ValveModelNumber { get; set; }
		public ValveTrim ValveTrim { get; set; }
		public FlangeFaceSurfaceFinish FlangeFaceSurfaceFinish { get; set; }
		public SurfacePreparation SurfacePreparation { get; set; }
		public ManufacturingMethod ManufacturingMethod { get; set; }

		public MiscRequisitionClassification MiscRequisitionClassification { get; set; }

		public int? PipingPointBasis1 { get; set; }
		public int? Id1 { get; set; }
		public PressureRating PressureRating1 { get; set; }
		public EndPreparation EndPreparation1 { get; set; }
		public EndPreparation EndStandard1 { get; set; }
		public ScheduleThickness ScheduleThickness1 { get; set; }
		public FlowDirection FlowDirection1 { get; set; }

		public int? PipingPointBasis2 { get; set; }
		public int? Id2 { get; set; }
		public PressureRating PressureRating2 { get; set; }
		public EndPreparation EndPreparation2 { get; set; }
		public EndPreparation EndStandard2 { get; set; }
		public ScheduleThickness ScheduleThickness2 { get; set; }
		public FlowDirection FlowDirection2 { get; set; }

		public string PipingNote1 { get; set; }

		public float? DryWeight { get; set; }
		public UnitType DryWeightUnits { get; set; }

		public float? DryCogX { get; set; }
		public UnitType DryCogXUnits { get; set; }

		public float? DryCogY { get; set; }
		public UnitType DryCogYUnits { get; set; }

		public float? DryCogZ { get; set; }
		public UnitType DryCogZUnits { get; set; }

		public float? WaterWeight { get; set; }
		public UnitType WaterWeightUnits { get; set; }

		public float? WaterCogX { get; set; }
		public UnitType WaterCogXUnits { get; set; }

		public float? WaterCogY { get; set; }
		public UnitType WaterCogYUnits { get; set; }

		public float? WaterCogZ { get; set; }
		public UnitType WaterCogZUnits { get; set; }

		public float? SurfaceArea { get; set; }
		public UnitType SurfaceAreaUnits { get; set; }

		public float? VolumetricCapacity { get; set; }
		public UnitType VolumetricCapacityUnits { get; set; }

		public int Npd1 { get; set; }
		public UnitType NpdUnitType1 { get; set; }

		public int Npd2 { get; set; }
		public UnitType NpdUnitType2 { get; set; }

		public float FacetoCenter { get; set; }
		public UnitType FacetoCenterUnits { get; set; }
	}
}
