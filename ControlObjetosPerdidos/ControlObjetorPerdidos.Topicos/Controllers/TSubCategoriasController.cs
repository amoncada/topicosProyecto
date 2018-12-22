using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlObjetorPerdidos.Topicos.DataBase;

namespace ControlObjetorPerdidos.Topicos.Controllers
{
    public class TSubCategoriasController : Controller
    {
        private DataBaseModel db = new DataBaseModel();

        // GET: TSubCategorias
        public ActionResult Index()
        {
            var tSubCategoria = db.TSubCategoria.Include(t => t.IdSubCategoria);
            return View(tSubCategoria.ToList());
        }

        // GET: TSubCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            if (tSubCategoria == null)
            {
                return HttpNotFound();
            }
            return View(tSubCategoria);
        }

        // GET: TSubCategorias/Create
        public ActionResult Create()
        {
            ViewBag.IdCategoria = new SelectList(db.TCategoria, "IdCategoria", "Nombre");
            ViewBag.vIdCategoria = TempData["vCat"];
            //var x = ViewBag.vIdCategoria;
            return View();
        }

        // POST: TSubCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSubCategoria,IdCategoria,Nombre,Descripcion")] TSubCategoria tSubCategoria)
        {
            if (ModelState.IsValid)
            {
                db.TSubCategoria.Add(tSubCategoria);
                db.SaveChanges();
                return RedirectToAction("Edit", "TCategorias", new { id = tSubCategoria.IdCategoria }); ;
            }

            ViewBag.IdCategoria = new SelectList(db.TCategoria, "IdCategoria", "Nombre", tSubCategoria.IdCategoria);
            return View(tSubCategoria);
        }

        // GET: TSubCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            if (tSubCategoria == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategoria = new SelectList(db.TCategoria, "IdCategoria", "Nombre", tSubCategoria.IdCategoria);
            return View(tSubCategoria);
        }

        // POST: TSubCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSubCategoria,IdCategoria,Nombre,Descripcion")] TSubCategoria tSubCategoria)
        {
            if (ModelState.IsValid)
            {
                tSubCategoria.IdCategoria  = db.TSubCategoria.AsNoTracking().Where(vIdSub => vIdSub.IdSubCategoria.Equals(tSubCategoria.IdSubCategoria)).Single().IdCategoria;

                db.Entry(tSubCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "TCategorias", new { id = tSubCategoria.IdCategoria });
            }
            ViewBag.IdCategoria = new SelectList(db.TCategoria, "IdCategoria", "Nombre", tSubCategoria.IdCategoria);
            return View(tSubCategoria);
        }

        // GET: TSubCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            if (tSubCategoria == null)
            {
                return HttpNotFound();
            }
            return View(tSubCategoria);
        }

        // POST: TSubCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            int vIdCat = tSubCategoria.IdCategoria;
            db.TSubCategoria.Remove(tSubCategoria);
            db.SaveChanges();
            return RedirectToAction("Edit", "TCategorias", new { id = vIdCat });   
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: 
        public ActionResult VolverEditarCategoria(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return RedirectToAction("Edit", "TCategorias", new { id = id });
        }

    }
}
