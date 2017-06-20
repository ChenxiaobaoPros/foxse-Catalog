using CatalogModel;
using Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Manager.Controllers
{
	public class CodelistsController : Controller
	{
		IEnumerable<Type> _types = typeof(CatalogContext).Assembly.ExportedTypes;
		// GET: Codelists
		public ActionResult Index(string n)
		{
			List<ICodelist> list = new List<ICodelist>();
			List<string> names = new List<string>() { n };

			var type = _types.Where(t => t.Name == n).SingleOrDefault();

			if (type != null)
			{
				ICodelist parent = null;

				using (CatalogContext db = new CatalogContext())
				{
					var set = db.Set(type);

					foreach (ICodelist item in set)
					{
						if (item.Parent != null)
						{
							parent = item.Parent;
							names.Add(parent.Name);
							var childs = parent.Childs;
							while (parent.Parent != null)
							{
								parent = parent.Parent;
								names.Add(parent.Name);
								childs = parent.Childs;
							}
							break;
						}
						else
						{
							list.Add(item);
						}
					}

					if (parent != null)
					{
						set = db.Set(parent.GetType());
						foreach (ICodelist item in set)
						{
							var childs = item.Childs;
							foreach (var c in childs)
							{
								var cc = c.Childs;
							}
							list.Add(item);
						}
					}
				}
			}
			ViewBag.NamesCount = names.Count - 1;
			ViewBag.Names = names;

			ViewBag.Title = n;

			return View(list);
		}


		[HttpPost]
		public ActionResult Add()
		{
			var n = Request.Form["n"];
			var typeName = Request.Form["typeName"];
			var parentID = (Request.Form["parentID"] == "")? "0" : Request.Form["parentID"];
			var parentName = Request.Form["parentName"];
			var shortDescription = Request.Form["shortDescription"];
			var longDescription = Request.Form["longDescription"];

			if (Request.Form["codelistNumber"] == "" || shortDescription == "")
			{
				return Redirect("~/Codelists?n=" + n);
			}

			var codelistNumber = Request.Form["codelistNumber"];
			var sortOrder = (Request.Form["sortOrder"] == "")? "0" : Request.Form["sortOrder"];
				
			var type = _types.Where(t => t.Name == typeName).SingleOrDefault();

			if (type != null)
			{
				using (CatalogContext db = new CatalogContext())
				{
					var t = new object[] { codelistNumber, shortDescription, longDescription, sortOrder };

					var tt = Activator.CreateInstance(type, t);

					if (parentName != "")
					{
						var parentType = _types.Where(i => i.Name == parentName).SingleOrDefault();

						var keys = new object[] { int.Parse(parentID) };

						var parent = db.Set(parentType).Find(keys);

						((ICodelist)tt).Parent = (ICodelist)parent;
					}

					db.Set(type).Add(tt);

					db.SaveChanges();
				}
			}
			return Redirect("~/Codelists?n="+ n);
		}

		public ActionResult Delete(string n, int id)
		{
			var type = _types.Where(t => t.Name == n).SingleOrDefault();

			if (type != null)
			{
				using (CatalogContext db = new CatalogContext())
				{
					var keys = new object[] { id };
					var ent = db.Set(type).Find(keys);

					db.Set(type).Remove(ent);

					db.SaveChanges();
				}
			}

			return Redirect("~/Codelists?n=" + n);
		}

		public ActionResult Edit(string id)
		{
			ICodelist result = null;
			var n = id.Split('_');
			var type = _types.Where(t => t.Name == n[0]).SingleOrDefault();

			if (type != null)
			{
				using (CatalogContext db = new CatalogContext())
				{
					var keys = new object[] { int.Parse(n[1]) };
					result = (ICodelist)db.Set(type).Find(keys);
					var par = result.Parent;
				}
			}

			return PartialView(result);
		}

		[HttpPost]
		public ActionResult Save(CodelistEditModel model)
		{
			var typeName = model.Name;

			var type = _types.Where(t => t.Name == typeName).SingleOrDefault();

			if (type != null)
			{
				using (CatalogContext db = new CatalogContext())
				{
					var keys = new object[] { model.ID };

					var res = (ICodelist)db.Set(type).Find(keys);
					if (res != null)
					{
						res.ShortDescription = model.ShortDescription;
						res.LongDescription = model.LongDescription;
						res.CodelistNumber = model.CodelistNumber;
						res.SortOrder = model.SortOrder;
						db.Entry(res).State = EntityState.Modified;
						db.SaveChanges();
					}
				}
			}
			return Redirect("~/Codelists?n=" + model.Name);
		}
	}
}