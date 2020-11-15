using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjCrudEF.Models;

namespace PrjCrudEF.Controllers
{
    public class LinqController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: Linq
        public ActionResult Index()
        {
            return View();
        }
		//display the customer details by region

		public ActionResult GetCategorybyregion()
		{
		
			//display the customer details group by region
			List<string> c = (from cust in db.Customers orderby cust.Region select cust.CustomerID).ToList();

			return View(c);
		}
		//display the customer who is from germany

			public ActionResult Customer()
		{
			List<Customer> customer = (from c in db.Customers where c.Country == "germany" select c).ToList();
			return View(customer);
		}


		//display employee whose region is notnull

		public ActionResult EmployeeRegionnotnull()
		{

			List<Employee> employees = (from e in db.Employees where e.Region != null select e).ToList();

			return View(employees);
		}

		//display the customer info for orderid 10248
		public ActionResult ParticularOrderid()
		{

			List<Customer> customer = (from o in db.Orders
									   join c in db.Customers on o.CustomerID equals c.CustomerID
									   where o.OrderID == 10248
									   select c).ToList();

			return View(customer);
		}
	}
}