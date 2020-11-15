using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrjMVCFirstApp.Controllers
{
    public class ViewDat_Bag_TempdataController : Controller
    {
        // GET: ViewDat_Bag_Tempdata
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Rules()
		{
			List<string> rule = new List<string>()
			{ "Avoid T-shirt","carry your d card"};
			//both viewbad and viewdata used to transfer from controller to view
			//dynamic property
			//viewBag.variablename=value;
			ViewBag.getrules = rule;
			//not a dynmaic property
			//viewdata["variablename"]=value;
			ViewData["follow"] = rule;
			return View();
		}
		public ActionResult FirstRequest()
		{
			List<string> TempDataTest = new List<string>();
			TempDataTest.Add("tejas");
			TempDataTest.Add("jaggu");
			TempDataTest.Add("rakesh");
			TempData["Emp"] = TempDataTest;

			//to retain data for any no of subsequent request
			TempData.Keep();
			return View();

		}
		public ActionResult SecondRequest()
		{
			List<string> n =TempData["Emp"] as List<string>;

			return View(n);

		}
    }
}