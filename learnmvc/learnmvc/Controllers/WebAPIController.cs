using Microsoft.AspNetCore.Mvc;

namespace learnmvc.Controllers
{
    [Route("api/[controller]/[action]")] //to call specific action, placing actionin route
    [ApiController]
    public class WebAPIController : ControllerBase
    {
            // GET: api/<WebAPIController>
            [HttpGet]
            public object Getdata()
            {
                //return new string[] { "value1", "value2" };
                return new { Name = "Prishni", Address = "pepsicola,kathmandu" }; //displays in json format
            }
            public List<object> GetUsers()
            {
                List<object> list = new List<object>(); //creating new list
                list.Add(new { name = "Ankit", address = "Kapan" });
                list.Add(new { name = "Sudikshya", address = "Jadibuti" });
                list.Add(new { name = "Smriti", address = "Banepa" });
                return list; // displays json data in a list
            }
    }

}
