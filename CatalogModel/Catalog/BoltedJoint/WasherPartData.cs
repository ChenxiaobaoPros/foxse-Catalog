using CatalogModel.Codelists;

namespace CatalogModel.Catalog.BoltedJoint
{
	public class WasherPartData
    {
		public int ID { get; set; }
		public string IndustryCommodityCode { get; set; }

//		public int? WasherTypeID { get; set; }
		public WasherType WasherType { get; set; }

//		public int? GeometricIndustryStandardID { get; set; }
		public GeometricIndustryStandard GeometricIndustryStandard { get; set; }

//		public int? MaterialsGradeID { get; set; }
		public MaterialsGrade MaterialsGrade { get; set; }

		public float WasherThickness { get; set; }

//		public int? UnitTypeID { get; set; }
		public UnitType WasherThicknessUnits { get; set; }
	}
}
