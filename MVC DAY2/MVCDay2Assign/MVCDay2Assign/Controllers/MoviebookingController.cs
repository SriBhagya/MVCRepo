using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay2Assign.Controllers
{
    public class MoviebookingController : Controller
    {
        // GET: Moviebooking
        public ActionResult Index()
        {
            return View();
        }
    }
}