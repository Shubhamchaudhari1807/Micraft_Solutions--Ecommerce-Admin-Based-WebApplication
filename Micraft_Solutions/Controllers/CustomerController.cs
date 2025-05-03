using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Models;
using System.Data.Entity;
using Micraft_Solutions.Data_Context;
 
namespace Micraft_Solutions.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Customer_Partial(int id)
        {
            Customer model;
            using (Db_MicraftEntities db = new Db_MicraftEntities())
            {
                var getdata = new  m_Customer();
                getdata = db.m_Customer.Where(x => x.Customer_Id == id).FirstOrDefault();
                model = new Customer()
                {
                    Customer_Id=getdata.Customer_Id,
                    Customer_Name = getdata.Customer_Name,
                    Customer_Address = getdata.Customer_Address,
                    Customer_City = getdata.Customer_City,
                   Pin_Code=getdata.Pin_Code


                };
            }
            return PartialView("Index", model);
        }

        public ActionResult SaveOrUpdate(FormCollection collection)
        {

            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                int pincode;
                int.TryParse(collection.Get("Pin_Code"), out pincode);
                try
                {
                    m_Customer _Customer = new m_Customer()
                    {
                        Customer_Name=collection.Get("Customer_Name"),
                        Customer_Address=collection.Get("Customer_Address"),
                        Customer_City =collection.Get("Customer_City"),
                        Pin_Code=pincode
                        
                    };
                    _db.Entry(_Customer).State = EntityState.Added;
                    _db.SaveChanges();

                }
                catch(Exception x)
                {
                    throw x;
                }
            }
                          
                
                return RedirectToAction("Index");
        }
        public ActionResult Customer_Report()
        {


            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {

                return View(_db.Sp_m_Customer().ToList());
            }

            //return RedirectToAction("Index");

        }
    }
}