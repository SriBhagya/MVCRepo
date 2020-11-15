using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDay2Assign.Models;

namespace MVCDay2Assign.Controllers
{
    public class MovieController : Controller
    {
		DBmovieEntities db = new DBmovieEntities();
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
		//1 fetching data from movies table
		public ActionResult GetMovieDetails()
		{
			List<Movietable> mov = db.Movietables.ToList();
			return View(mov);
		}

		//with scaffolding
		//2 fetching data from movies table
		public ActionResult GetMovieDetailsScaffold()
		{
			List<Movietable> mov = db.Movietables.ToList();
			return View(mov);
		}

		//Adding new movie deatils
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(Movietable movietable)
		{
			db.Movietables.Add(movietable);
			db.SaveChanges();
			return RedirectToAction("GetMovieDetailsScaffold");
		}

		//deleting-no need view for delete
		public ActionResult Delete(int id)
		{
			Movietable movietable = db.Movietables.Find(id);
			db.Movietables.Remove(movietable);
			db.SaveChanges();
			return RedirectToAction("GetMovieDetailsScaffold");
		}

		//display details
		public ActionResult Details(int id)
		{
			Movietable movietable = db.Movietables.Find(id);
			return View(movietable);
		}


		//edit
		public ActionResult Edit(int id)
		{
			Movietable movietable = db.Movietables.Find(id);
			return View(movietable);
		}
		[HttpPost]
		public ActionResult Edit(Movietable c)
		{
			Movietable movietable = db.Movietables.Find(c.MovieID);
			movietable.MovieID = c.MovieID;
			movietable.Moviename = c.Moviename;
			movietable.releasedate = c.releasedate;
			db.SaveChanges();
			return RedirectToAction("GetMovieDetailsScaffold");
		}

		////display the movie info in a particular year
		//public ActionResult Particularyear()
		//{

		//	List<Movietable> movietable = (from r in db.Movietables
		//								 join m in db.Movietables on r.releasedate equals m.releasedate
		//								 where r.releasedate = 2005
		//								   select m).ToList();

		//	return View(movietable);
		//}





	}
}