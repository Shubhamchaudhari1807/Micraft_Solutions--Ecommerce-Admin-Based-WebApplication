using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Micraft_Solutions.Models;
using Micraft_Solutions.Data_Context;
using System.Data.Entity;
using System.Web.Security;

namespace Micraft_Solutions.Controllers
{
        public class Login_PageController : Controller
        {
            #region
            string Session_user_name = "";
            int Session_user_id;
            #endregion
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult Check_Authandication(FormCollection collection)
            {
                string user_name = "";
                string user_password = "";

                user_name = collection.Get("user_name");
                user_password = collection.Get("user_password");

                using (Db_MicraftEntities db = new Db_MicraftEntities())
                {
                    var get_data = new User_Table();

                    get_data = db.User_Table.Where(x => x.User_Name == user_name
                      && x.Password == user_password).FirstOrDefault();

                    if (get_data != null)
                    {
                        Session_user_id = get_data.User_id;
                        Session_user_name = get_data.User_Name;

                        Session.Add("User_id", get_data.User_id);
                        Session.Add("User_name", get_data.User_Name);
                        FormsAuthentication.SetAuthCookie(Session_user_name, false);
                        return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        return RedirectToAction("Index", "Login_Page");
                    }
                }

            }
        }
    }
