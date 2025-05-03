using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Micraft_Solutions.Controllers
{
    public class OrderDetailsController : Controller
    {
        // GET: OrderDetails
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OrderDetails_Partial_View()
        {
            return View();
        }
    }
}