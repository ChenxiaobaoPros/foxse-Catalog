using CatalogModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Manager.Controllers
{
	public class SpecificationController : Controller
    {
        // GET: Codelists
        public ActionResult Index(string n)
        {
			List<ICodelist> list = new List<ICodelist>();

			var type = typeof(CatalogContext).Assembly.ExportedTypes.Where(t=>t.Name == n).SingleOrDefault();

			using (CatalogContext db = new CatalogContext())
			{
				var set = db.Set(type);

				foreach (var item in set)
				{
					list.Add((ICodelist)item);
				}
			}

			ViewBag.Title = n;

			return View(list);
        }
	}
}