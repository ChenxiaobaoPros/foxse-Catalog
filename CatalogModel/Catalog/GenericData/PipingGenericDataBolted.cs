using CatalogModel.Codelists;

namespace CatalogModel.Catalog.GenericData
{
	/// <summary>
	/// Параметры болтовых соединений
	/// </summary>
	public class PipingGenericDataBolted
    {
		public int ID { get; set; }
		public int NominalPipingDiameter { get; set; }
		public UnitType NominalDiameterUnits { get; set; }
		public PressureRating PressureRating { get; set; }
		public EndPreparation EndPreparation { get; set; }
		public EndStandard EndStandard { get; set; }
		public float FlangeOutsideDiameter { get; set; }
		public UnitType FlangeOutsideDiameterUnits { get; set; }

		public float FlangeThickness { get; set; }
		public UnitType FlangeThicknessUnits { get; set; }

		public float FlangeThicknessTolerance { get; set; }
		public UnitType FlangeThicknessToleranceUnits { get; set; }

		public float FlangeFaceProjection { get; set; }
		public UnitType FlangeFaceProjectionUnits { get; set; }

		public float RaisedFaceDiameter { get; set; }
		public UnitType RaisedFaceDiameterUnits { get; set; }

		public float FlangeGrooveWidth { get; set; }
		public UnitType FlangeGrooveWidthUnits { get; set; }

		public float SeatingDepth { get; set; }
		public UnitType SeatingDepthUnits { get; set; }

		public float BoltCircleDiameter { get; set; }
		public UnitType BoltCircleDiameterUnits { get; set; }

		public int QuantityOfBoltsRequired { get; set; }

		public float BoltDiameter { get; set; }
		public UnitType BoltDiameterUnits { get; set; }

		public float BodyOutsideDiameter { get; set; }
		public UnitType BodyOutsideDiameterUnits { get; set; }
		
		public DrillingTemplatePattern DrillingTemplatePattern { get; set; }

		public float BoltPatternLength { get; set; }
		public UnitType BoltPatternLengthUnits { get; set; }

		public float BoltPatternWidth { get; set; }
		public UnitType BoltPatternWidthUnits { get; set; }

		public float GroovePitchDiameter { get; set; }
		public UnitType GroovePitchDiameterUnits { get; set; }

		public float LapThickness { get; set; }
		public UnitType LapThicknessUnits { get; set; }

		public float CounterBoreDepth { get; set; }
		public UnitType CounterBoreDepthUnits { get; set; }

		public float BoltPatternOffset { get; set; }
		public UnitType BoltPatternOffsetUnits { get; set; }
	}
}
