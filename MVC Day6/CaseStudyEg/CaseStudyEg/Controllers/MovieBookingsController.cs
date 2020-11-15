using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CaseStudyEg.Models;

namespace CaseStudyEg.Controllers
{
    public class MovieBookingsController : Controller
    {
        private DBmovieEntities db = new DBmovieEntities();

        // GET: MovieBookings
        public ActionResult Index()
        {
            var movieBookings = db.MovieBookings.Include(m => m.Movie).Include(m => m.Screen).Include(m => m.Theater);
            return View(movieBookings.ToList());
        }

        // GET: MovieBookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieBooking movieBooking = db.MovieBookings.Find(id);
            if (movieBooking == null)
            {
                return HttpNotFound();
            }
            return View(movieBooking);
        }

        // GET: MovieBookings/Create
        public ActionResult Create()
        {
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName");
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID");
            ViewBag.TheaterID = new SelectList(db.Theaters, "TheaterID", "TheaterName");
            return View();
        }

        // POST: MovieBookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID,Customer,MovieID,TheaterID,ScreenID,NoofSeats,TotalAmount")] MovieBooking movieBooking)
        {
            if (ModelState.IsValid)
            {
                db.MovieBookings.Add(movieBooking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", movieBooking.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", movieBooking.ScreenID);
            ViewBag.TheaterID = new SelectList(db.Theaters, "TheaterID", "TheaterName", movieBooking.TheaterID);
            return View(movieBooking);
        }

        // GET: MovieBookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieBooking movieBooking = db.MovieBookings.Find(id);
            if (movieBooking == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", movieBooking.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", movieBooking.ScreenID);
            ViewBag.TheaterID = new SelectList(db.Theaters, "TheaterID", "TheaterName", movieBooking.TheaterID);
            return View(movieBooking);
        }

        // POST: MovieBookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID,Customer,MovieID,TheaterID,ScreenID,NoofSeats,TotalAmount")] MovieBooking movieBooking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieBooking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "MovieName", movieBooking.MovieID);
            ViewBag.ScreenID = new SelectList(db.Screens, "ScreenID", "ScreenID", movieBooking.ScreenID);
            ViewBag.TheaterID = new SelectList(db.Theaters, "TheaterID", "TheaterName", movieBooking.TheaterID);
            return View(movieBooking);
        }

        // GET: MovieBookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieBooking movieBooking = db.MovieBookings.Find(id);
            if (movieBooking == null)
            {
                return HttpNotFound();
            }
            return View(movieBooking);
        }

        // POST: MovieBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieBooking movieBooking = db.MovieBookings.Find(id);
            db.MovieBookings.Remove(movieBooking);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
