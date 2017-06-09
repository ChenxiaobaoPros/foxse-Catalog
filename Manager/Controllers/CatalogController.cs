using System.Web.Mvc;

namespace Manager.Controllers
{
	public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }
    }
}