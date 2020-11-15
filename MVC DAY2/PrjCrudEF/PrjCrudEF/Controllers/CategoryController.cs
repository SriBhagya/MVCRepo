using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCrudEF.Models;

namespace PrjCrudEF.Controllers
{
    public class CategoryController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View();
			
        }

		//1 fetching data from categories table
		public ActionResult GetCategoryDetails()
		{
			List<Category> cate = db.Categories.ToList();
			return View(cate);
		}
		//with scaffolding
		//2 fetching data from categories table
		public ActionResult GetCategoryDetailsScaffold()
		{
			List<Category> cate = db.Categories.ToList();
			return View(cate);
		}
		//Adding new category deatils
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Category category)
		{
			db.Categories.Add(category);
			db.SaveChanges();
			return RedirectToAction("GetCategoryDetailsScaffold");
		}
		//deleting-no need view for delete
		public ActionResult Delete(int id)
		{
			Category category= db.Categories.Find(id);
			db.Categories.Remove(category);
			db.SaveChanges();
			return RedirectToAction("GetCategoryDetailsScaffold");
		}
		//display details
		#region Display
		public ActionResult Details(int id)
		{
			Category category = db.Categories.Find(id);
			return View(category);
		}

		#endregion

		//edit
		public ActionResult Edit(int id)
		{
			Category category = db.Categories.Find(id);
			return View(category);
		}
		[HttpPost]
		public ActionResult Edit(Category c)
		{
			Category category = db.Categories.Find(c.CategoryID);
			category.CategoryName = c.CategoryName;
			category.Description = c.Description;
			category.Picture = c.Picture;
			db.SaveChanges();
			return RedirectToAction("GetCategoryDetailsScaffold");
		}

		public ActionResult GetCategorybyname()
		{
			//query syntax
			//display the category in ascending order
			List<string> c = (from cat in db.Categories orderby cat.CategoryName select cat.CategoryName).ToList();


			//method sybtac
			//dynamic c1=db.Categories.OrderBy(ca=> ca.CategoryName.ToList();

			return View(c);
		}
	}
}