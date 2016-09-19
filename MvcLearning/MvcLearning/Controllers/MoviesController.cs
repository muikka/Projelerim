using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using MvcLearning.Models;
using MvcLearning.ViewModels;

namespace MvcLearning.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewmodel);

        }

        public ActionResult Edit(int id)
        {

            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if(movie==null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };



            return View("MovieForm",viewModel);
        }

        public ActionResult New()
        {
            var movie=new Movie();
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c=>c.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c=>c.Id==id);

            if (movie == null)
                return (HttpNotFound());

            return View(movie);
        }

        [Route("movies/releasedate/{year:range(2010,2016)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(MovieFormViewModel movieViewModel)
        {
            if (!ModelState.IsValid)
            {
                
                var genres = _context.Genres.ToList();

                var viewModel = new MovieFormViewModel
                {
                    Movie = movieViewModel.Movie,
                    Genres = genres
                };

                return View("MovieForm", viewModel);
            }

            if (movieViewModel.Movie.Id == 0)
            {
                _context.Movies.Add(movieViewModel.Movie);
            }
                
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id== movieViewModel.Movie.Id);
                if(movieInDb==null)
                    return HttpNotFound();
                else
                {
                    movieInDb.Name = movieViewModel.Movie.Name;
                    movieInDb.ReleaseDate = movieViewModel.Movie.ReleaseDate;
                    movieInDb.DateAdded = movieViewModel.Movie.DateAdded;
                    movieInDb.GenreId = movieViewModel.Movie.GenreId;
                    movieInDb.NumberInStok = movieViewModel.Movie.NumberInStok;

                }

                
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}