using GIG_HUB.Models;
using GIG_HUB.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace GIG_HUB.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigsFormViewModel() { Genres = _context.Genres.ToList() };
            return View(viewModel);
        }
    }
}