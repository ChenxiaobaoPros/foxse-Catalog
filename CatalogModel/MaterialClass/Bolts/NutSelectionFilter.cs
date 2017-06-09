﻿using CatalogModel.Codelists;
using CatalogModel.MaterialClass.Piping;
using System.ComponentModel.DataAnnotations;

namespace CatalogModel.MaterialClass.Bolts
{
	public class NutSelectionFilter
    {
		[Key]
		public int ID { get; set; }

		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public NutOption NutOption { get; set; }

		public float MaximumTemperature { get; set; }
		public UnitType MaximumTemperatureUnits { get; set; }

		public BoltType BoltType { get; set; }

		public float BoltDiameter { get; set; }
		public UnitType BoltDiameterUnits { get; set; }

		public PressureRating PressureRating { get; set; }
		public string ContractorCommodityCode { get; set; }

		public SupplementaryNutRequirement SupplementaryNutOption { get; set; }
		public string SupplNutCntrCommodityCode { get; set; }


		public FabricationType FabricationCategoryOverride { get; set; }
		public SupplyResponsibility SupplyResponsibilityOverride { get; set; }

		public string Comments { get; set; }
		public string PipingNote1 { get; set; }

	}
}
