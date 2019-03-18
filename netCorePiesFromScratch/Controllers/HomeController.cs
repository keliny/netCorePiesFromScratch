using Microsoft.AspNetCore.Mvc;
using netCorePiesFromScratch.Models;
using netCorePiesFromScratch.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netCorePiesFromScratch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        // This is DI - since it is defined in startup class, this will auto create the repository
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to the Pie shop!",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            var DetailViewModel = new DetailViewModel()
            {
                Title = pie.Name,
                Pie = pie
            };
            return View(DetailViewModel);
        }
    }
}
