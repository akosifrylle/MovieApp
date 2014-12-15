using System.Web.Mvc;
using MovieDB.Services;

namespace MovieDB.Web.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        public ActionResult Index()
        {
            GenreService genreService = new GenreService();

            genreService.Save(new Genre
            {
                Name = "Rock"
            });
            return View();
        }
    }
}