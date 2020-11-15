using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjLayoutAuth.Controllers
{
    public class UserAuthenticationController : Controller
    {
        // GET: UserAuthentication
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Login(FormCollection frm)
		{
			if (frm["txtuname"] =="Rani" && frm["txtpwd"] == "123")
			{
				Session["Loginstatus"] = "valid";
				Session["Userid"] = frm["txtuname"];
				return RedirectToAction("Index");
			}
			else
			{
				Session["Loginstatus"] = "Invalid";
				return View();
			}
		}

		public ActionResult LogOff()
		{
			Session.Clear();
			return RedirectToAction("Index", "Home");
		}
    }
}