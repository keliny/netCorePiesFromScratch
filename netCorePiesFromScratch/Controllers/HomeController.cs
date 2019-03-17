using Microsoft.AspNetCore.Mvc;
using netCorePiesFromScratch.Models;
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
            ViewBag.Title = "Pies overview page!";

            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            return View(pies);
        }
    }
}
