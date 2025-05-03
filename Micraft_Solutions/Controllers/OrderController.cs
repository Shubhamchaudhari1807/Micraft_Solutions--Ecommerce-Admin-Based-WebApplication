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
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {

            var Order_model= new Order();
            var line_model = new List<OrderDetails>();

            ViewBag.Customer = Customer_Drop_Down();
            ViewBag.Product_Code = Product_Codc();
            Order_Order_Detiles_Bind model;
            model = new Order_Order_Detiles_Bind()
            {
                obj_order_model = Order_model,
                obj_order_detils_model =line_model
            };

            return View(model);
        }
        public ActionResult Order_Partial_View()
        {
            return View();

        }
        public ActionResult Line_Partial_View()
        {
            return View();
        }
        public List<SelectListItem> Product_Codc()
        {
            var _select_list = new List<SelectListItem>();
            _select_list.Add(new SelectListItem { Value = "0", Text = "Select Product Code" });

            var get_product_code = (dynamic)null;

            using(Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                get_product_code = from x in _db.m_Product
                                   select new
                                   {
                                       x.Product_Id,
                                       x.Product_Name
                                   };

                foreach(var item in get_product_code)
                {
                    _select_list.Add(new SelectListItem { Value = item.Product_Id.ToString(), Text = item.Product_Name.ToString() });
                }
            }

            return _select_list;
        }
        public List<SelectListItem> Customer_Drop_Down()
        {
            var _select_list = new List<SelectListItem>();
            _select_list.Add(new SelectListItem { Value = "0", Text = "Select Customer" });

            var get_customer = (dynamic)null;

            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                get_customer = from x in _db.m_Customer
                               select new
                               {
                                   x.Customer_Id,
                                   x.Customer_Name
                               };

                foreach (var item in get_customer)
                {
                    _select_list.Add(new SelectListItem { Value = item.Customer_Id.ToString(), Text = item.Customer_Name.ToString() });
                }
            }

            return _select_list;
        }
        public ActionResult Get_Product_Data(int product_id)
        {
            decimal _rate;
            string _unit;
            string _image_path;
            var get_data = (dynamic)null;
            using(Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                get_data = (from m in _db.m_Product where m.Product_Id == product_id select m).FirstOrDefault();

                decimal.TryParse(get_data.Product_Rate.ToString(), out _rate);
                _unit = get_data.Product_Unit;
                _image_path = get_data.Product_Image;

                var res = new { Product_Rate = _rate ,Unit= _unit ,image_path= _image_path };
                return Json(res, JsonRequestBehavior.AllowGet);

            }
        }

        public ActionResult SaveOrUpdate(FormCollection collection)
        {
            int _Order_hedar_id;
            int customerid;
            DateTime orderdate;
            decimal totalamt;
            int.TryParse(collection.Get("Customer_Id"), out customerid);
            DateTime.TryParse(collection.Get("Order_Date"), out orderdate);
            decimal.TryParse(collection.Get("Total_Amount"), out totalamt);

            using (Db_MicraftEntities _db = new Db_MicraftEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    try
                    {
                        m_Order _m_Order = new m_Order()
                        {
                            Customer_Id = customerid,
                            Total_Amount = totalamt,
                            Order_Date = orderdate,
                            Total_Qty = collection.Get("Total_Qty")
                        };

                        _db.Entry(_m_Order).State = EntityState.Added;
                        _db.SaveChanges();
                        _Order_hedar_id = _m_Order.Order_Id;

                        string[] sale_line_id = collection.Get("item.Line_ID").Split(',');
                        string[] ProductCode = collection.Get("item.ProductCode").Split(',');
                        string[] product_img = collection.Get("item.product_img").Split(',');
                        string[] unit = collection.Get("item.unit").Split(',');
                        string[] rate = collection.Get("item.rate").Split(',');
                        string[] qty = collection.Get("item.qty").Split(',');
                        string[] amount = collection.Get("item.amount").Split(',');
                        int _sale_line_id;
                        int.TryParse(collection.Get("item.Line_ID"), out _sale_line_id);

                        using (Db_MicraftEntities dbtest = new Db_MicraftEntities())
                        {
                            for (int i = 0; i < ProductCode.Length; i++)
                            {
                                if (sale_line_id[i] != "0")
                                {
                                    int _sale_line;
                                    int _ProductCode;
                                    //string _product_img;
                                    //string _unit;
                                    decimal _rate;
                                    decimal _qty;
                                    decimal _amount;

                                    int.TryParse(ProductCode[i], out _ProductCode);
                                    int.TryParse(sale_line_id[i], out _sale_line);
                                    decimal.TryParse(qty[i], out _qty);
                                    decimal.TryParse(amount[i], out _amount);
                                    decimal.TryParse(rate[i], out _rate);

                                    t_line_order _t_line_order = new t_line_order()
                                    {
                                        OrderID = _Order_hedar_id,
                                        ProductCode = _ProductCode,
                                    };
                                    dbtest.Entry(_t_line_order).State = EntityState.Added;
                                    dbtest.SaveChanges();
                                }
                                else
                                {

                                }
                            }
                        }
                            

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

                        }
                     
                    }
                }
            }
                return RedirectToAction("Index");
        }

    }
}