using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using MvcLearning.Models;

namespace MvcLearning.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            return View(movie);

        }

        public ActionResult Edit(int id)
        {
            return Content("Id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/releasedate/{year:range(2010,2016)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }


    
}
}