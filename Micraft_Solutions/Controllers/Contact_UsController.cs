using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Data_Context;
using Micraft_Solutions.Models;

namespace Micraft_Solutions.Controllers
{
    public class Contact_UsController : Controller
    {
        #region
        int server_responce;
        #endregion
        // GET: Contact_Us
        public ActionResult Index()
        {
            ViewBag._ex_cust = ex_Cust();
            return View();
        }
       
        public ActionResult Partial_View()
        {
            return View();
        }
        public List<SelectListItem> ex_Cust()
        {
            var _list = new List<SelectListItem>();
            _list.Add(new SelectListItem { Value = "0", Text = "---Select Remark---" });
            _list.Add(new SelectListItem { Value = "YES", Text = "YES" });
            _list.Add(new SelectListItem { Value = "NO", Text = "NO" });
            return _list;

        }
        public ActionResult Save(m_Contact_Us model)
        {
            ViewBag._ex_cust = ex_Cust();
            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        m_Contact_Us _m_Contact = new m_Contact_Us()
                        {
                            Full_Name = model.Full_Name,
                            Email = model.Email,
                            Customer_Message = model.Customer_Message,
                            attribute1 = model.attribute1

                        };
                        _db.Entry(_m_Contact).State = EntityState.Added;
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


    }
}