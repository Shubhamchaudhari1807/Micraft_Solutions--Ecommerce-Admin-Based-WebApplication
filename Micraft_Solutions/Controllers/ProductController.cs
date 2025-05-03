using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Models;
using System.Data.Entity;
using Micraft_Solutions.Data_Context;
using System.IO;
namespace Micraft_Solutions.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product_Partial_View()
        {
            return View();
        }
        public ActionResult Test(int id)
        {
            t_order model;
            using (Db_MicraftEntities _MicraftEntities = new Db_MicraftEntities())
            {
                var getdata = new m_Product();
                getdata = _MicraftEntities.m_Product.Where(x => x.Product_Id == id).FirstOrDefault();
                if (getdata != null)
                {
                 
                }

            }

                return View();
        }
        public ActionResult SaveOrUpdate(Product model)
        {

            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                string filename = Path.GetFileNameWithoutExtension(model.Product_Image.FileName);
                string extantion = Path.GetExtension(model.Product_Image.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extantion;
                model.image_path = "~/SaveImage/" + filename;
                filename = Path.Combine(Server.MapPath("~/SaveImage/"), filename);
                model.Product_Image.SaveAs(filename);

                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        m_Product _m_Product = new  m_Product()
                        {
                            Product_Name = model.Product_Name,
                            Product_Code=model.Product_Code,
                            Product_Image = model.image_path,
                            Product_Rate=model.Product_Rate,
                            Product_Unit=model.Product_Unit,
                            Product_Description=model.Product_Description                  
                        };
                        _db.Entry(_m_Product).State = EntityState.Added;
                        _db.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                raise = new InvalidOperationException(message, raise);
                            }

                            transaction.Rollback();
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        transaction.Commit();
                        transaction.Dispose();
                        _db.Database.Connection.Close();
                    }
                }
            }


            return RedirectToAction("Index");
        }
       
        public ActionResult Product_Report()
        {


            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                    return View(_db.Sp_m_Product_Report().ToList());
            }

        }
       

        public ActionResult Delete_Data(int id)
        {

            using (Db_MicraftEntities db = new Db_MicraftEntities())
            {
                m_Product table_obj = db.m_Product.Find(id);
                db.m_Product.Remove(table_obj);
                db.SaveChanges();
                TempData["Delete"] = "your data delete succefully........";
            }
            return RedirectToAction("Index");
        }

    }
}