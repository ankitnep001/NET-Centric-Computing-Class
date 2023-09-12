using LearningMVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace LearningMVC.Controllers
{
    public class CollegeController : Controller
    {
        IDateService _service;
        public CollegeController(IDateService dataservice)
        {
            _service = dataservice;
        }
        public IActionResult CollegeDetail()
        {
            CollegeModel clz = new CollegeModel();
            clz.CollegeName = "BMC";
            clz.CollegeAddress = "dudhPati";
            clz.University="TU";
            return View (clz);
        }
        public IActionResult CollegeList()
        {
/*            CollegeModel clz1 = new CollegeModel();
            clz1.CollegeName = "CSIT";
            clz1.CollegeAddress = "Bhaktapur";
            clz1.University = "TU";

            CollegeModel clz2 = new CollegeModel();
            clz2.CollegeName = "SVI";
            clz2.CollegeAddress = "banasthali";
            clz2.University = "KU";

            List<CollegeModel> listClz = new List<CollegeModel>();
            listClz.Add(clz1);
            listClz.Add(clz2);
            return View (listClz);*/

            List<CollegeModel> colleges = new List<CollegeModel>();
            StreamReader sr = new StreamReader("wwwroot/college.txt");
            string college = sr.ReadLine();
            while (college != null)
            {
                string[] collegeDetail = college.Split(',');
                CollegeModel clz = new CollegeModel();
                clz.CollegeName = collegeDetail[0];
                clz.CollegeAddress= collegeDetail[1];
                clz.University = collegeDetail[2];
                colleges.Add(clz);
                college=sr.ReadLine();
            }
            sr.Close();
            return View(colleges);
            
        }
        public IActionResult AddCollege()
        {
            return View();
        }


        public IActionResult CreateCollege(CollegeModel college) { 
            string datatosave = college.CollegeName+","+college.CollegeAddress+","+college.University;
            StreamWriter sw = new StreamWriter("wwwroot/college.txt",true);
            sw.WriteLine(datatosave);
            sw.Close();
            return RedirectToAction("CollegeList");
        }


        //week 5
        public IActionResult GetDate()
        {
            //IDateService dt = new DateService();
            return Content(_service.GetDate());
            //return Content("Trying other string");
        }

    }
}
