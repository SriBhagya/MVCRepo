using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace prjAttributeRoutingEg.Controllers
{
	[RoutePrefix("BookCollection")]
	public class BookController : Controller
	{
		// GET: Book
		[Route("All")]
        public ActionResult Index()
        {
            return View();
        }
		[Route("Books")]
		public ActionResult GetAllBooks()
		{
			return View();
		}
		
		//[Route("articles/{id:int:min(100)}")]
		
		//optional parameter

		[Route("Book/{id:int}")]
		public ActionResult GetBookByID()
		{
			return View();
		}
		[Route("Book/{name=Ram}")]
		public ActionResult GetBookByAuthor()
		{
			return View();
		}
		//Route constraint
		[Route("Book/{name:maxlength(4)}")]
		public ActionResult GetBookbyName(string name)
		{
			return View();
		}
	}
}