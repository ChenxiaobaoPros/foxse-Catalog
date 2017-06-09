using CatalogModel.Codelists;

namespace CatalogModel.Specification
{
	public class WeldModelRepresentation
    {
		public int ID { get; set; }

		public int NominalPipingDiameterFrom { get; set; }
		public int NominalPipingDiameterTo { get; set; }
		public UnitType NominalPipingDiameterUnits { get; set; }

		public WeldClass WeldClass { get; set; }

		public float WeldRadiusIncrease { get; set; }
		public UnitType WeldRadiusIncreaseUnits { get; set; }

		public float WeldThickness { get; set; }
		public UnitType WeldThicknessUnits { get; set; }

		public MaterialsGrade MaterialsGrade { get; set; }
	}
}
