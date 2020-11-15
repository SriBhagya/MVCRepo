using PrjMVCFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult FirstMethod()
		{
			return View();
		}
		//actionmethod returning viewresult
		public ViewResult SecondMethod()
		{
			return View();
		}
		//only displaying set of strings ---returns content in html
		public ContentResult Reply()
		{
			return Content("Good morning all!!</h1>","text/html");
		}
		//emplty result
		[NonAction]
		public EmptyResult Result()
		{
			int amount = 45000;
			float SI = (amount * 3 * 2) / 100;

			return new EmptyResult();
		}
		//return as json result
		public JsonResult Empdata()
		{
			Employee employee = new Employee();
			employee.id = 101;
			employee.name = "sunil";
			employee.age = 25;
			return Json(employee, JsonRequestBehavior.AllowGet);
		}

	}
}