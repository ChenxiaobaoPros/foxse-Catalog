using System.ComponentModel.DataAnnotations;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// Стандартные углы
	/// </summary>
	public class BendAngles
    {
		public int ID { get; set; }

		[Display(Order = 0)]
		public virtual PipingMaterialsClassData SpecName { get; set; }

		public int Npd { get; set; }
		public virtual UnitType NpdUnitType { get; set; }
		public float BendAngle { get; set; }
		public virtual UnitType BendAngleUnitType { get; set; }
	}
}
