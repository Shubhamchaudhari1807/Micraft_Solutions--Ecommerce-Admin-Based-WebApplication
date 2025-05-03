using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Micraft_Solutions.Data_Context;
using Micraft_Solutions.Models;

namespace Micraft_Solutions.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
   
        [HttpPost]
        public ActionResult SaveOrUpdate(FormCollection collection)
        {
            int seesion_user_id;
            string seesion_email_id;
            string user_name = "";
            string _password = "";

            user_name = collection.Get("email_id");
            _password = collection.Get("password");
            var _store_procedure_data = (dynamic)null;
            if (user_name != "" && _password != "")
            {
                using (Db_MicraftEntities _db = new Db_MicraftEntities())
                {
                    var get_data = new m_register();
                    get_data = _db.m_register.Where(m => m.email_id == user_name && m.password == _password).FirstOrDefault();

                    if (get_data != null)
                    {
                        seesion_user_id = get_data.customer_id;
                        seesion_email_id = get_data.email_id;
                        Session.Add("seesion_user_id", seesion_user_id);
                        Session.Add("seesion_email_id", seesion_email_id);
                        FormsAuthentication.SetAuthCookie(seesion_email_id, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Error"] = "Please check user name and password..";
                        return View("Order", "Index");
                    }
                }
            }
            else
            {
                TempData["Error"] = "Please check user name and password..";
                return View("Index");
            }




        }
    }
}