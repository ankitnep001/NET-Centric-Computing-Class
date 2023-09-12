using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    public class BMCController : Controller
    {

        /*public IActionResult Index()
        {
            return View();
        }*/
        public PartialViewResult Home()
        {
            return PartialView("Home");
        }
       
            public ContentResult Content()
        {
            return Content("nepal chor ho");
        }
        public JsonResult json()
        {
            return Json(new { name = "student", college = "BMC" });
        }
        public IActionResult Download()
        {
            return File("myfiles/hello.txt", "text/plain", "myfile.tx");
        }
    }
}
