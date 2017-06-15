using CatalogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace Manager.Controllers
{
	public class HomeController : Controller
	{
		private IEnumerable<IGrouping<string, string[]>> _catalogTypes;

		public HomeController()
		{
		}

		public ActionResult Index()
		{
			Assembly lib = typeof(CatalogModel.Codelists.AutomatedFlangeSelectionOption).Assembly;
			List<string[]> allTypes = new List<string[]>();
			foreach (Type type in lib.GetTypes().Where(t=>!t.Name.Contains("<>")))
			{
				if (!type.GetInterfaces().Contains(typeof(ICodelistCategory)))
				{
					var spl = type.FullName.Split('.');
					if (spl.Length > 2 && spl[1] != "Migrations")
						allTypes.Add(spl);
				}
			}

			_catalogTypes = allTypes.GroupBy(t => t[0]);

			return View(_catalogTypes);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}