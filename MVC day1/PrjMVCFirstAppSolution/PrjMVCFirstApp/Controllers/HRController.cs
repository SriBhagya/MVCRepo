using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrjMVCFirstApp.Models;

namespace PrjMVCFirstApp.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        
		public ActionResult DisplayEmployee()
		{
			Employee emp = new Employee();
			emp.id = 1001;
			emp.name = "banu";
			emp.age = 32;
			return View(emp);
		}
		public ActionResult ListDisplayEmployee()
		{
			List<Employee> e = new List<Employee>();
			e.Add(new Employee { id = 1001, name = "Mani", age = 25 });
			e.Add(new Employee { id = 1002, name = "Abhi", age = 24 });
			e.Add(new Employee { id = 1003, name = "Raju", age = 27 });
			return View(e);
		}
		public ActionResult Index()
		{
			List<Department> d = new List<Department>();
			d.Add(new Department { id = 10, dname = "CSE",  });
			d.Add(new Department { id = 11, dname = "IT",  });
			d.Add(new Department { id = 12, dname = "EEE",  });
			d.Add(new Department { id = 13, dname = "MECH", });

			return View("ListDepartmentDetails",d);
		}

		public ActionResult ListDepartmentDetails(Department department)
		{
			
			return View(department);
		}

		//call contact actionmetd of homecontroller
		public ActionResult CallContact()
		{
			return View("~/Views/Home/Contact.cshtml");
		}
		//redirect
		public ActionResult ReMethod()
		{
									//actionmethodname , controllername
			return RedirectToAction("FirstMethod", "Demo");
		}

		public ActionResult Tempdatafrom()
		{
			List<string> n1 = TempData["Emp"] as List<string>;
			return View(n1);
		}
	}
}