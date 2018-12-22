using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlObjetorPerdidos.Topicos.DataBase;
using ControlObjetorPerdidos.Topicos.Models;
//using System.ServiceModel;

namespace ControlObjetorPerdidos.Topicos.Controllers
{
    public class TCategoriasController : Controller
    {
        private DataBaseModel db = new DataBaseModel();

        // GET: TCategorias
        public ActionResult Index()
        {
            return View(db.TCategoria.ToList());
        }

        // GET: TCategorias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TCategoria tCategoria = db.TCategoria.Find(id);
            if (tCategoria == null)
            {
                return HttpNotFound();
            }

            return View(tCategoria);
        }

        // GET: TCategorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TCategorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCategoria,Nombre,Descripcion")] TCategoria tCategoria)
        {
            if (ModelState.IsValid)
            {
                db.TCategoria.Add(tCategoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tCategoria);
        }

        // GET: TCategorias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TCategoria tCategoria = db.TCategoria.Find(id);
            if (tCategoria == null)
            {
                return HttpNotFound();
            }
            List<TSubCategoria> vListaSub = new List<TSubCategoria>();
            vListaSub = db.TSubCategoria.Where(vSub => vSub.IdCategoria == id).ToList();
            ViewBag.vListaSubCat = vListaSub;

            //Se utiliza para el boton de Back to List del Crear subcategoria
            TempData["vCat"] = id;            
            return View(tCategoria);            
        }

        // POST: TCategorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCategoria,Nombre,Descripcion")] TCategoria tCategoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tCategoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tCategoria);
            //return View("Create", tCategoria);
        }












        // GET: TSubCategorias/Create
        public ActionResult CrearSubCat()
        {
            return RedirectToAction("Create", "TSubCategorias");
        }

        // GET: TSubCategorias/Edit
        public ActionResult EditarSubCat(int? id)
        {
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            return View("~/Views/TSubCategorias/Edit.cshtml", tSubCategoria);
        }

        // GET: TSubCategorias/Delete
        public ActionResult EliminarSubCat(int? id)
        {
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            return View("~/Views/TSubCategorias/Delete.cshtml", tSubCategoria);
        }

        // GET: TSubCategorias/Edit
        public ActionResult DetallesSubCat(int? id)
        {
            TSubCategoria tSubCategoria = db.TSubCategoria.Find(id);
            ViewBag.vIdEditSubCat = id;
            ViewBag.vIdCatDetailsSubCat = TempData["vCat"];
            return View("~/Views/TSubCategorias/Details.cshtml", tSubCategoria);
        }
















        // GET: TCategorias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TCategoria tCategoria = db.TCategoria.Find(id);
            if (tCategoria == null)
            {
                return HttpNotFound();
            }
            return View(tCategoria);
        }

        // POST: TCategorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TCategoria tCategoria = db.TCategoria.Find(id);
            db.TCategoria.Remove(tCategoria);
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
