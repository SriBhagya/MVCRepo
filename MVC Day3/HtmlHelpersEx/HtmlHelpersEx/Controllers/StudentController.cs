using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersEx.Models;
namespace HtmlHelpersEx.Controllers
{
    public class StudentController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
		//stronglt typed helper
		public ActionResult StronglyTypedCreate()
		{
			return View();
		}

		//templatedhelper 1
		public ActionResult TemplateHelper()
		{
			return View();
		}
		//templatedhelper 2
		public ActionResult EditorFormodelEg()
		{
			return View();
		}

		public ActionResult Create()
		{
			return View();
		}

		//using parameter
		[HttpPost]
		
		public ActionResult Create(string RegionDescription)
		{
			Region r = new Region();
			r.RegionDescription = RegionDescription;
			db.Regions.Add(r);
			db.SaveChanges();

			return View();
		}
		//request
		[HttpPost]
		[ActionName("Create")]
		public ActionResult CreatePost()
		{
			Region region = new Region();
			region.RegionID = Convert.ToInt32(Request["RegionID"]);
			region.RegionDescription = Request["RegionDescription"].ToString();
			db.Regions.Add(region);
			db.SaveChanges();
			return View();
		}
	}
}