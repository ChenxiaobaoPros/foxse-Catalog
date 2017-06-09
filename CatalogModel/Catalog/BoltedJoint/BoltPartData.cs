using CatalogModel.Codelists;

namespace CatalogModel.Catalog.BoltedJoint
{
	/// <summary>
	/// Болты/шпильки
	/// </summary>
	public class BoltPartData
    {
		public int ID { get; set; }
		public string IndustryCommodityCode { get; set; }
		public BoltType BoltType { get; set; }
		public GeometricIndustryStandard GeometricIndustryStandard { get; set; }
		public MaterialsGrade MaterialsGrade { get; set; }
		public CoatingType CoatingType { get; set; }
	}
}
