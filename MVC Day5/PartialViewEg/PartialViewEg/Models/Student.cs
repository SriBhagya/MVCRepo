using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewEg.Models
{
	public partial class Student
	{
		public int Psno { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
	}
	public partial class Student
	{
		public List<Student> students { get; set; }
	}
}