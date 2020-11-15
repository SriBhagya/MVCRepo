using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace prjCodeFirstEg.Models
{
	[Table("tblcar")]
	public class Car
	{

		[Key]
		public int carno { get; set; }
		public int carname { get; set; }
		public int cartype { get; set; }
	}
}