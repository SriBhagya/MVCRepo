using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eager_Lazy_LoadingEg.Models;

namespace Eager_Lazy_LoadingEg.Controllers
{
    public class LoadingController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: Loading
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult ELLoading()
		{
			//display product details
			var p = (from pr in db.Products
					 select pr).ToList();
			//display supplier name an products supplied by supplier
			var su = (from s in db.Suppliers
					  join pr in db.Products
					  on s.SupplierID equals pr.SupplierID
					  select new { s.CompanyName, pr.ProductName }).ToList();
			return View(su);
		}

		public ActionResult EagerLoading()
		{
			//disable lazy loading
			db.Configuration.LazyLoadingEnabled = false;

			var sup = db.Suppliers.Include("Products").ToList();
			
			//products supplied by particular supplier
			var supplier1 = (from s in db.Suppliers
							 .Include("Products")  //productmodel table to be included
							 where s.SupplierID == 20
							 select s).ToList();
			return View(sup);
		}
		//1
		public ActionResult Displayemployees()
		{
			var emp = (from e in db.Employees
					   select new { FullName = e.FirstName + "" + e.LastName }).ToList();
			return View(emp);
		}
		//2
		public ActionResult CustomerDetails()
		{
			var cust = (from c in db.Customers
						where c.Fax != null
						select c).ToList();

			return View(cust);

		}
		//3
		public ActionResult GetOrderDetails()
		{
			var ord = (from o in db.Order_Details.Include("Product")
					   where o.UnitPrice > 10 && o.UnitPrice < 20
					   select o).ToList();

			return View(ord);
		}






	}
}