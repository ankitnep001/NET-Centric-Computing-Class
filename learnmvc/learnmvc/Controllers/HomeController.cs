using learnmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace learnmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult labsheet3()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Content()
        {
            return Content("This is the output returned when action is return type is Content.");
        }

        public JsonResult json()
        {
            return Json(new { name = "Prishni", lastname = "Ghimire" });
        }
        public IActionResult Partial()
        {
            return PartialView("Partial"); // layout is discarded
        }
        public IActionResult Download()
        {
            return File("~/labsheet3.txt", "text/plain", "labsheet3.txt");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}