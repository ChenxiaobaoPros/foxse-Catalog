namespace Manager.Models
{
	public class CodelistEditModel
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int ParentID { get; set; }
		public string ParentName { get; set; }
		public string TwoFactor { get; set; }
		public string TypeName { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public int CodelistNumber { get; set; }
		public int SortOrder { get; set; }
	}
}