using Microsoft.AspNetCore.Mvc;
using netCorePiesFromScratch.Models;

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
            return View();
        }
    }
}
