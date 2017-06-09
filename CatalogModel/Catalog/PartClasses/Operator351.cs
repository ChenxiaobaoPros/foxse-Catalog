using CatalogModel.Codelists;

namespace CatalogModel.Catalog.PartClasses
{
	/// <summary>
	/// Редуктор ручной
	/// </summary>
	public class Operator351
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

		public float? HwXOffsetFrmOpStem { get; set; }
		public UnitType HwXOffsetFrmOpStemUnits { get; set; }

		public float? HwZOffsetOpFrmStem { get; set; }
		public UnitType HwZOffsetOpFrmStemUnits { get; set; }

		public float? HwOffsetFrmValCen { get; set; }
		public UnitType HwOffsetFrmValCenUnits { get; set; }

		public float? OperatorHeight { get; set; }
		public UnitType OperatorHeightUnits { get; set; }

		public float? HWDiameter { get; set; }
		public UnitType HWDiameterUnits { get; set; }

		public float? OffsetFrmValCen { get; set; }
		public UnitType OffsetFrmValCenUnits { get; set; }
	}
}
