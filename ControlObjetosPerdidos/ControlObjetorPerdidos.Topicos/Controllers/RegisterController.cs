using ControlObjetorPerdidos.Topicos.DataBase;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace ControlObjetorPerdidos.Topicos.Controllers
{

    public class RegisterController : Controller
    {
        private DataBaseModel db = new DataBaseModel();

        // GET: Register
        public ActionResult Index()
        {
            //var usuarios = db.TRegistros.ToList();
            //var listusuarios = new SelectList(usuarios, "RoleID", "RoleName");
            //ViewData["usuarios"] = listusuarios;

            return View();
        }

        public ActionResult Confirm(int regId)
        {
            ViewBag.regID = regId;
            return View();
        }

        private void createRoles()
        {
            DataBaseModel db = new DataBaseModel();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!roleManager.RoleExists("Custodia"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Custodia";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Administrador"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Administrador";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Invitado"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Invitado";
                roleManager.Create(role);
            }
        }

        public JsonResult RegisterConfirm(int regId)
        {
            TRegistros Data = db.TRegistros.Where(x => x.UserID == regId).FirstOrDefault();
            Data.IsValid = true;
            db.SaveChanges();
            var msg = "Tu email ya esta verificado!";
            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CheckUsernameAvailability(string userdata)
        {
            System.Threading.Thread.Sleep(200);
            var SeachData = db.TRegistros.Where(x => x.Email == userdata).SingleOrDefault();
            if (SeachData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }

        }

        public JsonResult SaveData([Bind(Include = "UserID,Username,Apellido,Password,Email,IsValid,Rol")]TRegistros model)
        {
            model.IsValid = false;
            db.TRegistros.Add(model);
            db.SaveChanges();
            var result = BuildEmailTemplate(model.UserID);
            return Json(new
            {
                redirectUrl = Url.Action(result, "Register"),
                isRedirect = true
            });
            //return Json("Registration Successfull", JsonRequestBehavior.AllowGet);
        }

        private string BuildEmailTemplate(int regID)
        {
            string body = System.IO.File.ReadAllText(HostingEnvironment.MapPath("~/EmailTemplate/") + "Text" + ".cshtml");
            var regInfo = db.TRegistros.Where(x => x.UserID == regID).FirstOrDefault();
            var url = "Confirm?regId=" + regID;
            body = body.Replace("@ViewBag.ConfirmationLink", url);
            body = body.ToString();
            return url;

        }

        public static void BuildEmailTemplate(string subjectText, string bodyText, string sendTo)
        {
            string from, to, bcc, cc, subject, body;
            from = "maryanguduar3@gmail.com";
            to = sendTo.Trim();
            bcc = "";
            cc = "";
            subject = subjectText;
            StringBuilder sb = new StringBuilder();
            sb.Append(bodyText);
            body = sb.ToString();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            if (!string.IsNullOrEmpty(bcc))
            {
                mail.Bcc.Add(new MailAddress(bcc));
            }
            if (!string.IsNullOrEmpty(cc))
            {
                mail.CC.Add(new MailAddress(cc));
            }
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            SendEmail(mail);
        }

        public static void SendEmail(MailMessage mail)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = false;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("amoncada10@gmail.com", "Amch5650");
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //login
        public JsonResult CheckValidUser(TRegistros model)
        {
            string result = "Fail";
            TRegistros login = null;
            using (DataBaseModel context = new DataBaseModel())
            {
                login = context.TRegistros.Where(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
            }

            //var DataItem = db.TRegistros.Where(x => x.Email == model.Email && x.Password == model.Password).SingleOrDefault();
            if (login != null)
            {
                Session["UserID"] = login.UserID.ToString();
                Session["UserName"] = login.Username.ToString();
                Session["UserRol"] = login.Rol.ToString();
                result = "Success";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AfterLogin()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}
