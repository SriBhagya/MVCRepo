using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelEg.Models;
using ViewModelEg.ViewModel;

namespace ViewModelEg.Controllers
{
    public class CustomerOrderController : Controller
    {
		NorthwindEntities db = new NorthwindEntities();
        // GET: CustomerOrder
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult CusOrder()
		{
			List<CustomerVM> CustomerVMList = new List<CustomerVM>();
			//query getting data from databse from joiing two tables and storing data in customerlist
			var customerlist = (from cust in db.Customers
								join or in db.Orders
								on cust.CustomerID equals or.CustomerID
								select new { cust.CustomerID, cust.CompanyName, cust.ContactName, or.OrderID, or.OrderDate }).ToList();
			//using foreach loop fill data customerlist to list<CustomerVM>
			foreach(var item in customerlist)
			{
				CustomerVM objcvm = new CustomerVM();  //ViewModel
				objcvm.CustomerID = item.CustomerID;
				objcvm.CompanyName = item.CompanyName;
				objcvm.CompanyName = item.ContactName;
				objcvm.OrderID = item.OrderID;
				objcvm.OrderDate = item.OrderDate;

				CustomerVMList.Add(objcvm);
			}
			//List OF CustomerVM(ViewModel)

			return View(CustomerVMList);

		}
    }
}