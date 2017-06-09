using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatalogModel;
using CatalogModel.MaterialClass.Piping;
using System.Reflection;
using System.Threading.Tasks;
using Manager.Models;

namespace Manager.Controllers
{
	public class MaterialClassController : Controller
	{
		private CatalogContext db = new CatalogContext();

		IEnumerable<Type> _types = typeof(CatalogContext).Assembly.ExportedTypes;

		// GET: PipingMaterialsClassDatas
		public async Task<ActionResult> Index(string n)
		{
			var type = _types.Where(t => t.Name == n).SingleOrDefault();

			var list = await db.Set(type).ToListAsync();

			ViewBag.Type = type; 

			return View(list);
		}

		// GET: PipingMaterialsClassDatas/Details/5
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PipingMaterialsClassData pipingMaterialsClassData = db.PipingMaterialsClassData.Find(id);
			if (pipingMaterialsClassData == null)
			{
				return HttpNotFound();
			}
			return View(pipingMaterialsClassData);
		}

		// GET: PipingMaterialsClassData/Create
		public ActionResult Create()
		{
			ViewBag.Selects = GetSelects();
			ViewBag.TypeName = "PipingMaterialsClassData";
			return View();
		}

		private Dictionary<string, List<SelectListItem>> GetSelects()
		{
			var selects = new Dictionary<string, List<SelectListItem>>();
			foreach (MethodInfo item in typeof(PipingMaterialsClassData).GetMethods())
			{
				if (/*item.IsVirtual && */item.ReturnType.GetInterface("ICodelist") != null)
				{
					var set = db.Set(item.ReturnType);
					var sli = new List<SelectListItem>();
					foreach (ICodelist i in set)
					{
						sli.Add(new SelectListItem()
						{
							Text = i.LongDescription,
							Value = i.ID.ToString()
						});
					}
					if (!selects.ContainsKey(item.ReturnType.Name))
						selects.Add(item.ReturnType.Name, sli);
				}
			}
			return selects;
		}

		// POST: PipingMaterialsClassDatas/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(object mc)
		{
			if (ModelState.IsValid)
			{
				var typeName = Request.Form["typeName"];

				var type = _types.Where(t => t.Name == typeName).SingleOrDefault();

				//var args = new object[] { mc };

				var tt = Activator.CreateInstance(type);

				foreach (var item in type.GetProperties())
				{
					var ipt = item.PropertyType;
					if (ipt.GetInterface("ICodelist") != null)
					{
						int parsed = 0;
						if (int.TryParse(Request.Form[item.Name], out parsed))
						{
							var value = await db.Set(ipt).FindAsync(new object[] { parsed });
							item.SetValue(tt, value);
						}
						else
						{
							item.SetValue(tt, null);
						}
					}
					else
					{
						switch (ipt.Name)
						{
							case "String":
								item.SetValue(tt, Request.Form[item.Name]);
								break;
							case "Nullable1":
								DateTime odt;
								if (DateTime.TryParse(Request.Form[item.Name], out odt))
								{
									item.SetValue(tt, odt);
								}
								else
								{
									item.SetValue(tt, null);
								}
								break;
						}
						
					}
				}

				db.Set(type).Add(tt);

				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(mc);
		}

		// GET: PipingMaterialsClassDatas/Edit/5
		public ActionResult Edit(int? id)
		{
			ViewBag.Selects = GetSelects();

			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PipingMaterialsClassData pipingMaterialsClassData = db.PipingMaterialsClassData.Find(id);
			if (pipingMaterialsClassData == null)
			{
				return HttpNotFound();
			}
			return View(pipingMaterialsClassData);
		}

		// POST: PipingMaterialsClassDatas/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(/*[Bind(Include = "ID,SpecName,MaterialsDescription,FluidService,Comments,RevisionNumber,ApprovedBy,ApprovalDate,JacketMatOfConstructionClass,JumperMatOfConstructionClass,JacketMaterialsDescription,JumperMaterialsDescription,JacketAndJumperFluidService,HyperlinkToHumanSpec,PipingNote1,WeldingProcedureSpecification")] */
			PipingMaterialsClassData pipingMaterialsClassData)
		{
			if (ModelState.IsValid)
			{
				db.Entry(pipingMaterialsClassData).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(pipingMaterialsClassData);
		}

		// GET: PipingMaterialsClassDatas/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			PipingMaterialsClassData pipingMaterialsClassData = db.PipingMaterialsClassData.Find(id);
			if (pipingMaterialsClassData == null)
			{
				return HttpNotFound();
			}
			return View(pipingMaterialsClassData);
		}

		// POST: PipingMaterialsClassDatas/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			PipingMaterialsClassData pipingMaterialsClassData = db.PipingMaterialsClassData.Find(id);
			db.PipingMaterialsClassData.Remove(pipingMaterialsClassData);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}

		private List<SelectListItem> ToListItems(List<ICodelist> input)
		{
			List<SelectListItem> listItems = new List<SelectListItem>();

			foreach (ICodelist i in input)
			{
				listItems.Add(new SelectListItem
				{
					Text = i.LongDescription,
					Value = i.ID.ToString()
				});
			}

			return listItems;
		}
	}
}
