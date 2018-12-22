using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
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
        public ActionResult Create([Bind(Include = "IdArticulo,IdSubCategoria,Marca,Modelo,Color,FechaExtravio,Descripcion,Email,Estado")] TArticulo tArticulo, TContacto tContacto)
        {
            if (ModelState.IsValid)
            {
                if(tContacto != null)
                {
                    var contacto = db.TContacto.Where(c => c.Email.Equals(tContacto.Email)).FirstOrDefault();
                    if (contacto != null)
                        tArticulo.Email = contacto.Email;
                }
                db.TArticulo.Add(tArticulo);
                db.SaveChanges();
            }
            ViewBag.IdSubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre");
            return RedirectToAction("Index");
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

        public ActionResult FileUpload()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase[] files)
        {
            //Ensure model state is valid  
            if (ModelState.IsValid)
            {   //iterating through multiple file collection   
                foreach (HttpPostedFileBase file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        // save the image path path to the database or you can send image 
                        // directly to database
                        // in-case if you want to store byte[] ie. for DB
                        using (MemoryStream ms = new MemoryStream())
                        {
                            file.InputStream.CopyTo(ms);
                            byte[] array = ms.GetBuffer();
                        }
                        // agregar fotos
                        //assigning file uploaded status to ViewBag for showing message to user.  
                        ViewBag.UploadStatus = files.Count().ToString() + " files uploaded successfully.";
                    }

                }
            }
            return View();
        }


        public ActionResult BuscarArticulo(String Colores, int? SubCategoria, DateTime? FechaInicial, DateTime? FechaFinal, String Descripcion, String Estado, int? Categoria)
        {

            var myColors = from firstList in db.TArticulo
                           group firstList by firstList.Color into newList
                           let m = newList.FirstOrDefault()
                           select m;
            var myStatus = from firstList in db.TArticulo
                           group firstList by firstList.Estado into newList
                           let m = newList.FirstOrDefault()
                           select m;


            ViewBag.Colores = new SelectList(myColors.ToList(), "Color", "Color");
            ViewBag.Estado = new SelectList(myStatus.ToList(), "Estado", "Estado");
            ViewBag.Categoria = new SelectList(db.TCategoria, "IdCategoria", "Nombre");
            ViewBag.SubCategoria = new SelectList(db.TSubCategoria, "IdSubCategoria", "Nombre");



            var tArticulo = db.TArticulo.Include(t => t.TSubCategoria);

            if (!String.IsNullOrEmpty(Colores))
            {

                tArticulo = tArticulo.Where(s => s.Color == Colores);
            }
            if (SubCategoria != null)
            {
                tArticulo = tArticulo.Where(s => s.IdSubCategoria == SubCategoria);
            }
            if (!String.IsNullOrEmpty(Descripcion))
            {
                tArticulo = tArticulo.Where(s => s.Descripcion.Contains(Descripcion)
                || s.Modelo.Contains(Descripcion) || s.Marca.Contains(Descripcion));
            }
            if (!String.IsNullOrEmpty(Estado))
            {
                tArticulo = tArticulo.Where(s => s.Estado == Estado);
            }
            if (FechaInicial != null)
            {
                tArticulo = tArticulo.Where(s => s.FechaExtravio >= FechaInicial);
            }
            if (FechaFinal != null)
            {
                tArticulo = tArticulo.Where(s => s.FechaExtravio <= FechaFinal);
            }
            if (Categoria != null)
            {
                tArticulo = tArticulo.Where(u => db.TSubCategoria.Where(crtu => crtu.IdCategoria == Categoria).Select(crtu => crtu.IdSubCategoria).Contains(u.IdArticulo));

            }
            return View(tArticulo.ToList());

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
