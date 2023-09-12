using learnmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace learnmvc.Controllers
{
    public class labreport4Controller : Controller
    {
        public IActionResult College()
        {
            List<CollegeModel> colleges = new List<CollegeModel>();
            StreamReader sr = new StreamReader("wwwroot/College.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] CollegeDetail = line.Split(',');
                CollegeModel college = new CollegeModel();
                college.CollegeName = CollegeDetail[0];
                college.Address = CollegeDetail[1];
                college.University = CollegeDetail[2];
                colleges.Add(college);
                line = sr.ReadLine();
            }
            sr.Close();

            return View(colleges);
        }
        public IActionResult AddCollege()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCollege(CollegeModel college)
        {
            string dataToSave = college.CollegeName + " , " + college.Address + ","+ college.University;
            StreamWriter sw = new StreamWriter("wwwroot/college.txt", append: true);
            sw.WriteLine(dataToSave);
            sw.Close();
            return RedirectToAction("College");
        }
    }
}
