namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Стандартные углы
	/// </summary>
	public class BendAngles
    {
		public int ID { get; set; }
		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public int Npd { get; set; }
		public UnitType NpdUnitType { get; set; }
		public float BendAngle { get; set; }
		public UnitType BendAngleUnitType { get; set; }
	}
}
