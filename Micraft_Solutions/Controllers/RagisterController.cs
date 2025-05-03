
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Models;
using Micraft_Solutions.Data_Context;

namespace Micraft_Solutions.Controllers
{
    public class RagisterController : Controller
    {
        // GET: Ragister
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register_partial_View()
        {
            return View();
        }
        public ActionResult Save(m_register model)
        {
            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                _db.Entry(model).State = System.Data.Entity.EntityState.Added;
                _db.SaveChanges();
                TempData["message"] = "Sucessfully Thank You!";
                
            }
            return RedirectToAction("index","Login");
        }


    }
}