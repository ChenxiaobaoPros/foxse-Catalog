using CatalogModel.Codelists;

namespace CatalogModel.Specification
{
	public class PipingCommodityMatlControlData
	{
		public int ID { get; set; }
		public string ContractorCommodityCode { get; set; }
		public string ClientCommodityCode { get; set; }
		public string CIMISCommodityCode { get; set; }
		
		public int FirstSizeFrom { get; set; }
		public int FirstSizeTo { get; set; }
		public UnitType FirstSizeUnits { get; set; }

		public int SecondSizeFrom { get; set; }
		public int SecondSizeTo { get; set; }
		public UnitType SecondSizeUnits { get; set; }

		//ICatalogElement CatalogElement { get; set; }
		public string IndustryCommodityCode { get; set; }


		public string ShortMaterialDescription { get; set; }
		public string LongMaterialDescription { get; set; }

		/// <summary>
		/// Производитель (ID или ShortDescription)
		/// </summary>
		public Vendor Vendor { get; set; }

		/// <summary>
		/// Изготовитель (ID или ShortDescription)
		/// </summary>
		public Manufacturer Manufacturer { get; set; }

		/// <summary>
		/// Кем и как производится сборка (ID или ShortDescription)
		/// </summary>
		public FabricationType FabricationType { get; set; }

		public SupplyResponsibility SupplyResponsibility { get; set; }

		/// <summary>
		/// Вывод в отчет
		/// </summary>
		public ReportingType ReportingType { get; set; }

		/// <summary>
		/// Количество, выводимое в отчеты
		/// </summary>
		public int QuantityOfReportableParts { get; set; }

		/// <summary>
		/// Требования к прокладкам
		/// </summary>
		public GasketRequirements GasketRequirements { get; set; }

		/// <summary>
		/// Требования к болтам
		/// </summary>
		public BoltingRequirements BoltingRequirements { get; set; }

		/// <summary>
		/// Требования к зажимам
		/// </summary>
		public ClampRequirement ClampRequirement { get; set; }

		/// <summary>
		/// Требования к сварке
		/// </summary>
		public WeldingRequirement WeldingRequirement { get; set; }

		public LooseMaterialRequirements LooseMaterialRequirements { get; set; }

		public int SubstCapScrewsQuantity { get; set; }
		public string SubstCapScrewCntrCommodityCode { get; set; }

		public int SubstCapScrewDiameter { get; set; }
		public UnitClass SubstCapScrewDiameterUnits { get; set; }

		public int TappedHoleDepth { get; set; }
		public int TappedHoleDepth2 { get; set; }
		public int CapScrewEngagementGap { get; set; }

		public MultiportValveOpReq MultiportValveOpReq { get; set; }

		public ValveOperatorType ValveOperatorType { get; set; }
		public ValveOperatorGeometricIndStd ValveOperatorGeoIndStd { get; set; }

		public string ValveOperatorCatalogPartNumber { get; set; }
		public string ReportableCommodityCode { get; set; }

		public PartDataSource PartDataSource { get; set; }

		public string AltOrientationCommodityCode { get; set; }
		public string HyperlinkToElectronicVendor { get; set; }
		public string HyperlinkToElectronicManuals { get; set; }
		public string PipingNote1 { get; set; }
		public string VendorPartNumber { get; set; }
		public string ManufacturerPartNumber { get; set; }
		public string AltReportableCommodityCode { get; set; }
		public int QuantityOfAltReportableParts { get; set; }
		public string eClasseProcurementCode { get; set; }
		public string UNSPSCeProcurementCode { get; set; }
		public string LegacyCommodityCode { get; set; }

	}
}