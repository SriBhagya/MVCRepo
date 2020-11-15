using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelEg.Models;
using ViewModelEg.ViewModel;

namespace ViewModelEg.Controllers
{
    public class CustOrderEmpController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: CustOrderEmp
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult CustOrderEmp()
		{
			List<ThreeTablesVM> ThreeTableslist = new List<ThreeTablesVM>();
			//getting data from 3 tables
			var employeelist = (from emp in db.Employees
								join cust in db.Orders
								on emp.EmployeeID equals cust.EmployeeID
								select new { cust.CustomerID, cust.CompanyName, cust.ContactName, or.OrderID, or.OrderDate emp.EmployeeID, emp.FirstName, emp.LastName }).ToList();

			return View(ThreeTableslist);
		}
    }
}