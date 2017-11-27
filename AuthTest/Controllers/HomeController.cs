using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Login()
        {
            if (Session["admin"] != null && Session["admin"].ToString() == "berkay")
                return RedirectToAction("Index", "Admin");
            else
                return View();
        }

        [HttpPost]
        public ActionResult Login(string kAd, string kSifre)
        {
            if(!string.IsNullOrEmpty(kAd) && !string.IsNullOrEmpty(kSifre))
            {
                if (kAd == "berkay" && kSifre == "123")
                {
                    Session["admin"] = "berkay";
                    return RedirectToAction("Index", "Admin");
                }
                else
                    Session["admin"] = null;
            }
            return RedirectToAction("Login");
        }
    }
}