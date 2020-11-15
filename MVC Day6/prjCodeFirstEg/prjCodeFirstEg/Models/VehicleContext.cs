using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace prjCodeFirstEg.Models
{
	public class VehicleContext:DbContext
	{
		public VehicleContext():base("name=efVehicles")
		{

		}
		public DbSet<Car> cars { get; set; }
	}
}