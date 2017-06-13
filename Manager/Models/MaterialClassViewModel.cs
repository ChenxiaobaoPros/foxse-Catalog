using System.Collections.Generic;
using System.Web.Mvc;

namespace Manager.Models
{
	public class MaterialClassViewModel
	{
		public Dictionary<string, List<SelectListItem>> Selects { get; set; }
		public object Item { get; set; }
		public string TypeName { get; set; }
	}
}