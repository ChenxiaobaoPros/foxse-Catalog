using CatalogModel.Codelists;

namespace CatalogModel.Catalog.PartClasses
{
	/// <summary>
	/// Электропривод
	/// </summary>
	public class Operator332
	{
		public int ID { get; set; }
		public string ValveOperatorNumber { get; set; }
		public int ValveSize { get; set; }
		public UnitType ValveSizeUnits { get; set; }
		public string SymbolDefinition { get; set; }
		public string SymbolIcon { get; set; }
		public MirrorBehaviorOption MirrorBehaviorOption { get; set; }
		public PartDataBasis DimensionalBasis { get; set; }
		public ValveOperatorIsRotatable ValveOperatorIsRotatable { get; set; }

		public float? DryWeight { get; set; }
		public UnitType DryWeightUnits { get; set; }

		public float? DryCogX { get; set; }
		public UnitType DryCogXUnits { get; set; }

		public float? DryCogY { get; set; }
		public UnitType DryCogYUnits { get; set; }

		public float? DryCogZ { get; set; }
		public UnitType DryCogZUnits { get; set; }

		public float? GearDiameter { get; set; }
		public UnitType GearDiameterUnits { get; set; }

		public float? GearRadius { get; set; }
		public UnitType GearRadiusUnits { get; set; }

		public float? GearDepth { get; set; }
		public UnitType GearDepthUnits { get; set; }

		public float? HWDiameter { get; set; }
		public UnitType HWDiameterUnits { get; set; }

		public float? HandWheelRadius { get; set; }
		public UnitType HandWheelRadiusUnits { get; set; }

		public float? HwXOffsetFrmOpStem { get; set; }
		public UnitType HwXOffsetFrmOpStemUnits { get; set; }

		public float? HwZOffsetOpFrmStem { get; set; }
		public UnitType HwZOffsetOpFrmStemUnits { get; set; }

		public float? HwYOffsetFrmGearBot { get; set; }
		public UnitType HwYOffsetFrmGearBotUnits { get; set; }

		public float? ValCenToHWTop { get; set; }
		public UnitType ValCenToHWTopUnits { get; set; }

		public float? ValCenToHWCen { get; set; }
		public UnitType ValCenToHWCenUnits { get; set; }

		public float? ExStemLen { get; set; }
		public UnitType ExStemLenUnits { get; set; }

		public float? ExStemLenFrmValCen { get; set; }
		public UnitType ExStemLenFrmValCenUnits { get; set; }

		public float? ExStemDia { get; set; }
		public UnitType ExStemDiaUnits { get; set; }
	}
}
