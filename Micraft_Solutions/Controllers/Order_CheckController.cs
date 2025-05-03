using Micraft_Solutions.Data_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micraft_Solutions.Controllers
{
    public class Order_CheckController : Controller
    {
        // GET: Order_Check
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial_View(int id)
        {
            t_order model;
            using (Db_MicraftEntities _MicraftEntities = new Db_MicraftEntities())
            {
                var getdata = new m_Product();
                getdata = _MicraftEntities.m_Product.Where(x => x.Product_Id == id).FirstOrDefault();
                TempData["Image_path"] = getdata.Product_Image;
                if (getdata != null)
                {
                    model = new t_order()
                    {
                        order_rate = Convert.ToDecimal(getdata.Product_Rate),
                        attr1=getdata.Product_Name,
                     


                    };
                    return PartialView("Index", model);
                }
             

            }
            return View();
        }
        public ActionResult Save(t_order model)
        {
            using(Db_MicraftEntities _context= new Db_MicraftEntities())
            {
                _context.Entry(model).State = System.Data.Entity.EntityState.Added;
                _context.SaveChanges();


            }
            TempData["message"] = "Your Order Place Successfully....!";
          return  RedirectToAction("Main_View", "Product_Selection");
        }
        

    }
}