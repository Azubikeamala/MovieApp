using Microsoft.AspNetCore.Mvc;
using MovieApp.Entities;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
      
        MovieDbContext _movieDbContext;
        // Alternatively, you can use the constructor injection to inject the MovieDbContext
        //  MovieDbContext MovieDbContext = new MovieDbContext();
        // without using this method called dependency injection as seen in the below method

        public MoviesController(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public IActionResult List()
        {
            List<Movie> movies;
            movies = _movieDbContext.Movies.ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieDbContext.Movies.Add(movie);
                _movieDbContext.SaveChanges();

                //The below is an option of copying and pasting the list again for return
                //List<Movie> movies;
                //movies = _movieDbContext.Movies.ToList();
                //return View("List", movies);

                //alternatively
                return RedirectToAction("List", "Movies");
                //The above script calls the list action from IActionResult List()
            }
            else
            {
                return View(movie);
            }
        }
    }
}
