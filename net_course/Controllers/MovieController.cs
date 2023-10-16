using Microsoft.AspNetCore.Mvc;
using net_course.Models;

namespace net_course.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			Movie movie = new Movie()
			{
			Name ="movie 1"
			};
			List<Movie> movies = new List<Movie>()
            {
           new Movie{Name="movie 2"},
           new Movie{Name="movie 3"},
            };
			return View(movies);
		}

		[Route("movie/hello/{id}")]
		public IActionResult Edit(int id)
		{
			return Content("Test Id" + id);
		}

        [Route("Movie/released/{year}/{month}")]
        public IActionResult ByRelease(int year, int month)
        {
            return Content($"Year: {year}, Month: {month}");
        }
    }
}
