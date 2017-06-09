﻿using CatalogModel.Codelists;

namespace CatalogModel.Catalog.PartClasses
{
	/// <summary>
	/// Ручной привод
	/// </summary>
	public class Operator5
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

		public float? OperatorHeight { get; set; }
		public UnitType OperatorHeightUnits { get; set; }

		public float? HandWheelDiameter { get; set; }
		public UnitType HandWheelDiameterUnits { get; set; }
	}
}
