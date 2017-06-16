using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Piping;
using CatalogModel.Specification;
using System.ComponentModel.DataAnnotations;

namespace CatalogModel.MaterialClass.Bolts
{
	public class WasherSelectionFilter
	{
		[Key]
		public int ID { get; set; }

		public virtual PipingMaterialsClassData SpecName { get; set; }

		public virtual WasherOption WasherOption { get; set; }

		public float MaximumTemperature { get; set; }
		public virtual UnitType MaximumTemperatureUnits { get; set; }

		public float BoltDiameter { get; set; }
		public virtual UnitType BoltDiameterUnits { get; set; }

		public virtual PressureRating PressureRating { get; set; }
		public virtual PipingCommodityMatlControlData ContractorCommodityCode { get; set; }

		public virtual FabricationType FabricationCategoryOverride { get; set; }
		public virtual SupplyResponsibility SupplyResponsibilityOverride { get; set; }

		public virtual SupplementaryWasherRequirement SupplementaryWasherReqmt { get; set; }
		public string SupplWasherCntrCommodityCode { get; set; }

		public string Comments { get; set; }
		public string PipingNote1 { get; set; }

	}
}
