using CatalogModel.Codelists;

namespace CatalogModel.Specification
{
	public class BoltExtension
    {
		public int ID { get; set; }

		public int NominalPipingDiameter { get; set; }
		public UnitType NominalPipingDiameterUnits { get; set; }

		public PressureRating PressureRating { get; set; }
		public EndPreparation EndPreparation { get; set; }
		public EndStandard EndStandard { get; set; }

		public int StandardBoltExtensionForStuds { get; set; }
		public UnitType StandardBoltExtensionForStudsUnits { get; set; }

		public int AltBoltExtensionForStuds2 { get; set; }
		public int AltBoltExtensionForStuds3 { get; set; }
		public int AltBoltExtensionForStuds4 { get; set; }
		public int AltBoltExtensionForStuds5 { get; set; }
		public int AltBoltExtensionForStuds6 { get; set; }

		public int StandardBoltExtForMachBolts { get; set; }
		public UnitType StandardBoltExtForMachBoltsUnits { get; set; }

		public int AltBoltExtForMachBolts { get; set; }
		public int AltBoltExtForMachBolts2 { get; set; }
		public int AltBoltExtForMachBolts3 { get; set; }
		public int AltBoltExtForMachBolts4 { get; set; }
		public int AltBoltExtForMachBolts5 { get; set; }
		public int AltBoltExtForMachBolts6 { get; set; }
	}
}
