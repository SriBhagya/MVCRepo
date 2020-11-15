using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCrudEF.Models;

namespace PrjCrudEF.Controllers
{
    public class MultiplrTableController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
		// GET: MultiplrTable
		public ActionResult Index()
        {
            return View();
        }
		public ActionResult OrderCustomerInfo()
		{
			return View(db.Orders.ToList());
		}
    }
}