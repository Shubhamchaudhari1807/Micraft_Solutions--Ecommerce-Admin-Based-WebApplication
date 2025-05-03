using Micraft_Solutions.Data_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micraft_Solutions.Controllers
{
    public class Product_SelectionController : Controller
    {
        // GET: Product_Selection
        public ActionResult Index()
        {
            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {

                return View(_db.Sp_m_Product_Report().ToList());
            }

        }
        public ActionResult Main_View()
        {
            return View();

        }
        public ActionResult Product_order(int id)
        {
            TempData["Product_id"] = id;
            //return RedirectToAction("Index","Order");
            return RedirectToAction("Partial_View", "Order_Check", new { @id = id });
        }
    }
}