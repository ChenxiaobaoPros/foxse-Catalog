using CatalogModel.Codelists;

namespace CatalogModel.Specification
{
	/// <summary>
	/// Названия типов деталей
	/// </summary>
	public class ShortCodeHierarchyRule
    {
		public int ID { get; set; }

		public ShortCodeHierarchyType ShortCodeHierarchyType { get; set; }

		public string ShortCode { get; set; }
	}
}
