namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// This lists the allowable nominal diameters for a given spec.
	/// Разрешенные диаметры (Ду)
	/// </summary>
	public class PipeNominalDiameters
    {
		public int ID { get; set; }
		public PipingMaterialsClassData PipingMaterialsClassData { get; set; }

		public string SpecName { get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; } }

		public int Npd { get; set; }
		public UnitType NpdUnitType { get; set; }
	}
}
