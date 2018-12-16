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
    public class TArticulosController : Controller
    {
        private DataBaseModel db = new DataBaseModel();

        // GET: TArticulos
        public ActionResult Index()
        {
            var tArticulo = db.TArticulo.Include(t => t.TSubCategoria);
            return View(tArticulo.ToList());
        }

        // GET: TArticulos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TArticulo tArticulo = db.TArticulo.Find(id);
            if (tArticulo == null)
            {
                return HttpNotFound();
            }
            return View(tArticulo);
        }

        // GET: TArticulos/Create
        public ActionResult Create()
        {
            ViewBag.IdSubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre");
            return View();
        }

        // POST: TArticulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdArticulo,IdSubCategoria,Marca,Modelo,Color,FechaExtravio,Descripcion,Email,Estado")] TArticulo tArticulo)
        {
            if (ModelState.IsValid)
            {
                db.TArticulo.Add(tArticulo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre", tArticulo.IdSubCategoria);
            return View(tArticulo);
        }

        // GET: TArticulos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TArticulo tArticulo = db.TArticulo.Find(id);
            if (tArticulo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre", tArticulo.IdSubCategoria);
            return View(tArticulo);
        }

        // POST: TArticulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdArticulo,IdSubCategoria,Marca,Modelo,Color,FechaExtravio,Descripcion,Email,Estado")] TArticulo tArticulo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tArticulo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre", tArticulo.IdSubCategoria);
            return View(tArticulo);
        }

        // GET: TArticulos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TArticulo tArticulo = db.TArticulo.Find(id);
            if (tArticulo == null)
            {
                return HttpNotFound();
            }
            return View(tArticulo);
        }

        // POST: TArticulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TArticulo tArticulo = db.TArticulo.Find(id);
            db.TArticulo.Remove(tArticulo);
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
    }
}
