using learnmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace learnmvc.Controllers
{
    public class DateController : Controller
    {
        IDateService _service;
        public DateController(IDateService dateService)
        {
            _service = dateService;
        }
        //public IActionResult GetDate()
        //{

            //DateService dateService = new DateService();
            //return Content(_service.GetDate().ToString());
        //}
    }
}
