using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Data_Context;
namespace Micraft_Solutions.Controllers
{
    public class Order_ReportController : Controller
    {
        // GET: Order_Report
        public ActionResult Index()
        {
            using (Db_MicraftEntities _context = new Db_MicraftEntities())
            {
                return View(_context.Sp_m_t_order_Result().ToList());
            }

        }
        public ActionResult Main_View()
        {
            return View();
        }


    }
}