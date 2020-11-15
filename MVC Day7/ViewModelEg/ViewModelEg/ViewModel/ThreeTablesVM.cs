using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModelEg.ViewModel
{
	public class ThreeTablesVM
	{
		[Key]
		public string CustomerID { get; set; }//Csutomer.cs
		public string CompanyName { get; set; }//Customer.cs
		public string ContactName { get; set; }//Customer.cs
		public int OrderID { get; set; }//Order.cs
		public Nullable<System.DateTime> OrderDate { get; set; }//Order.cs
		public string EmployeeID { get; set; }//employee.cs
		public string LastName { get; set; }//employee.cs
		public string FirstName { get; set; }//order.cs
	}
}