using CatalogModel.Codelists;

namespace CatalogModel.Catalog.GenericData
{
	/// <summary>
	/// Параметры приварных соединений
	/// </summary>
	public class PlainPipingGenericData
    {
		public int ID { get; set; }
		
		public int NominalPipingDiameter { get; set; }
		public UnitType NominalDiameterUnits { get; set; }
		public EndStandard EndStandard { get; set; }
		public ScheduleThickness Schedule { get; set; }
		public PressureRating PressureRating { get; set; }

		public float PipingOutsideDiameter { get; set; }
		public UnitType PipingOutsideDiameterUnits { get; set; }

		public float WallThickness { get; set; }
		public UnitType WallThicknessUnits { get; set; }
	}
}
