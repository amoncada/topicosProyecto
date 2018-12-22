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
    public class TContactoController : Controller
    {
        private DataBaseModel db = new DataBaseModel();
  
        public ActionResult AdministrarContacto()
        {
            ViewBag.Role = new SelectList(db.Role, "RoleName", "RoleName");
            var Contacto = db.TContacto;

            return View(Contacto);
        }



        [HttpPost]
        public ActionResult AdministrarContacto(String Email, String Role) {

            if (!String.IsNullOrEmpty(Email)|| !String.IsNullOrEmpty(Role)) {
                TContacto Contacto = db.TContacto.Where(s => s.Email == Email).FirstOrDefault();
                Contacto.rol = Role;
                db.Entry(Contacto).State = EntityState.Modified;
                db.SaveChanges();
            }


            ViewBag.Role = new SelectList(db.Role, "RoleName", "RoleName");
            return RedirectToAction("AdministrarContacto");
        }

    }
}
