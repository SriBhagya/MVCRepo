using PartialViewEg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewEg.Controllers
{
	public class StudentController : Controller
	{
		// GET: Student
		public ActionResult Index()
		{
			return View();
		}
		public List<Student> ChennaiDetails()
		{
			List<Student> ch = new List<Student>();
			ch.Add(new Student { Psno = 1, Name = "Anshul", Location = "Chennai" });
			ch.Add(new Student { Psno = 2, Name = "Ashish", Location = "Chennai" });
			ch.Add(new Student { Psno = 3, Name = "Anshu", Location = "Chennai" });
			return ch;

		}
		public List<Student> BangaloreDetails()
		{
			List<Student> ch = new List<Student>();
			ch.Add(new Student { Psno = 4, Name = "Bala", Location = "Bangalore" });
			ch.Add(new Student { Psno = 5, Name = "Bhagya", Location = "Bangalore" });
			ch.Add(new Student { Psno = 6, Name = "Bhavya", Location = "Bangalore" });
			return ch;
		}
		public ActionResult Chennailist()
		{
			return View(new Student() { students = ChennaiDetails() });
		}
		public ActionResult Bangalorelist()
		{
			return View(new Student() { students = BangaloreDetails() });
		}
	}
}