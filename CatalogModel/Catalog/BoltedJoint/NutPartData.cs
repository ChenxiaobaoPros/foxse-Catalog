using CatalogModel.Codelists;

namespace CatalogModel.Catalog.BoltedJoint
{
	/// <summary>
	/// Гайки
	/// </summary>
	public class NutPartData
    {
		public int ID { get; set; }
		public string IndustryCommodityCode { get; set; }

		//public int? NutTypeID { get; set; }
		public NutType NutType { get; set; }

		//public int? GeometricIndustryStandardID { get; set; }
		public GeometricIndustryStandard GeometricIndustryStandard { get; set; }

//		public int? MaterialsGradeID { get; set; }
		public MaterialsGrade MaterialsGrade { get; set; }

		public float NutHeight { get; set; }

//		public int? UnitTypeID { get; set; }
		public UnitType NutHeightUnits { get; set; }
	}
}
