using CatalogModel.Codelists;
using CatalogModel.Specification;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Для заполнения спецификации классов
	/// </summary>
	public class PipingCommodityFilter
    {
		public int ID { get; set; }
		public virtual PipingMaterialsClassData SpecName { get; set; }

		//[NotMapped, Display(Description = "/MaterialClass?n=PipingMaterialsClassData")]
		//public string SpecName {
		//	get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; }
		//	set
		//	{
		//		//int index = 0;
		//		if (value != null)
		//		{
		//			using (CatalogContext db = new CatalogContext())
		//			{
		//				PipingMaterialsClassData = db.PipingMaterialsClassData.Where(i => i.SpecName == value).FirstOrDefault(); // .Find(new object[] { index });
		//				db.SaveChanges();
		//			}
		//		}
		//		else
		//		{
		//			PipingMaterialsClassData = null;
		//		}
		//	}
		//}

		public virtual ShortCodeHierarchyRule ShortCode { get; set; }

		//[NotMapped, Display(Description = "/Specification?n=ShortCodeHierarchyRule")]
		//public string ShortCode
		//{
		//	get
		//	{
		//		return (ShortCodeHierarchyRule == null || ShortCodeHierarchyRule.ShortCode == null) ? "unset" : ShortCodeHierarchyRule.ShortCode;
		//	}
		//	set
		//	{
		//		if (value != null)
		//		{
		//			using (CatalogContext db = new CatalogContext())
		//			{
		//				ShortCodeHierarchyRule = db.ShortCodeHierarchyRules.Where(i => i.ShortCode == value).FirstOrDefault(); // .Find(new object[] { index });
		//				db.SaveChanges();
		//			}
		//		}
		//		else
		//		{
		//			ShortCodeHierarchyRule = null;
		//		}
		//	}
		//}

		public string Comments { get; set; }

		public int FirstSizeFrom { get; set; }
		public int FirstSizeTo { get; set; }
		public virtual UnitType FirstSizeUnits { get; set; }

		public int SecondSizeFrom { get; set; }
		public int SecondSizeTo { get; set; }
		public virtual UnitType SecondSizeUnits { get; set; }

		public virtual CommodityOption OptionCode { get; set; }
		public string MultisizeOption { get; set; }
		public virtual SelectionBasis SelectionBasis { get; set; }
		public virtual FluidCode FluidCode { get; set; }
		public virtual JacketedPipingBasis JacketedPipingBasis { get; set; }

		public float MaximumTemperature { get; set; }
		public virtual UnitType MaximumTemperatureUnits { get; set; }
		public float MinimumTemperature { get; set; }
		public virtual UnitType MinimumTemperatureUnits { get; set; }

		/// <summary>
		/// Суффикс при именовании в дереве проекта
		/// </summary>
		public virtual string EngineeringTag { get; set; }

		public virtual PipingCommodityMatlControlData CommodityCode { get; set; }

		//[NotMapped, Display(Description = "/Specification?n=PipingCommodityMatlControlData")]
		//public string CommodityCode {
		//	get	{ return (PipingCommodityMatlControlData == null || PipingCommodityMatlControlData.ContractorCommodityCode == null) ? "unset" : PipingCommodityMatlControlData.ContractorCommodityCode; }
		//	set
		//	{
		//		if (value != null)
		//		{
		//			using (CatalogContext db = new CatalogContext())
		//			{
		//				PipingCommodityMatlControlData = db.PipingCommodityMatlControlData.Where(i => i.ContractorCommodityCode == value).FirstOrDefault(); // .Find(new object[] { index });
		//				db.SaveChanges();
		//			}
		//		}
		//		else
		//		{
		//			PipingCommodityMatlControlData = null;
		//		}
		//	}
		//}

		public string FabricationCategoryOverride { get; set; }
		public string SupplyResponsibilityOverride { get; set; }
		public string FirstSizeSchedule { get; set; }
		public string SecondSizeSchedule { get; set; }
		public string ReportableCommodityCode { get; set; }
		public int QuantityOfReportableParts { get; set; }
		public string AssociatedCommodityCode { get; set; }

		/// <summary>
		/// Для гибов трубы можно задать свой коэффициент радиуса гиба от диаметра
		/// </summary>
		public float BendRadiusMultiplier { get; set; }

		/// <summary>
		/// Для гибов трубы можно задать свой радиус
		/// </summary>
		public float BendRadius { get; set; }
		public int NumberOfMiterCuts { get; set; }
		public virtual UnitType FirstSizeUOMBasisInCatalog { get; set; }
		public virtual UnitType SecondSizeUOMBasisInCatalog { get; set; }
		public int PDSModifier { get; set; }
		public float PreferredPipeLength { get; set; }
		public string PipingNote1 { get; set; }
		public string AltReportableCommodityCode { get; set; }
		public int QuantityOfAltReportableParts { get; set; }

	}
}
