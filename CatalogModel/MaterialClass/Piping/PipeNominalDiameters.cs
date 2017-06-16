using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CatalogModel.MaterialClass.Piping
{
	/// <summary>
	/// This lists the allowable nominal diameters for a given spec.
	/// Разрешенные диаметры (Ду)
	/// </summary>	
	public class PipeNominalDiameters
    {
		public int ID { get; set; }
		public virtual PipingMaterialsClassData SpecName { get; set; }

		//[NotMapped, Display(Description = "/MaterialClass?n=PipingMaterialsClassData")]
		//public string SpecName {
		//	get { return (PipingMaterialsClassData == null || PipingMaterialsClassData.SpecName == null) ? "unset" : PipingMaterialsClassData.SpecName; }
		//	set
		//	{
		//		if (value != null)
		//		{
		//			using (CatalogContext db = new CatalogContext())
		//			{
		//				PipingMaterialsClassData = db.PipingMaterialsClassData.Where(i => i.SpecName == value).FirstOrDefault();
		//				db.SaveChanges();
		//			}
		//		}
		//		else
		//		{
		//			PipingMaterialsClassData = null;
		//		}
		//	}
		//}

		public int Npd { get; set; }
		public virtual UnitType NpdUnitType { get; set; }
	}
}
