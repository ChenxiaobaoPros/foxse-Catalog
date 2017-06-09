using CatalogModel.Codelists;

namespace CatalogModel.Specification
{
	public class PreferredStudBoltLength
    {
		public int ID { get; set; }

		public int BoltDiameterFrom { get; set; }
		public UnitType BoltDiameterFromUnits { get; set; }

		public int BoltDiameterTo { get; set; }
		public UnitType BoltDiameterToUnits { get; set; }

		public int BoltDiameterIncrement { get; set; }
		public UnitType BoltDiameterIncrementUnits { get; set; }

		public MaterialsGrade MaterialsGrade { get; set; }

		public float PreferredBoltLengthFrom { get; set; }
		public UnitType PreferredBoltLengthFromUnits { get; set; }

		public float PreferredBoltLengthTo { get; set; }
		public UnitType PreferredBoltLengthToUnits { get; set; }

		public float PreferredBoltLengthIncrement { get; set; }
		public UnitType PreferredBoltLengthIncrementUnits { get; set; }
	}
}
