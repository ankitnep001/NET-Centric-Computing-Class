using LearningMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetail()
        {
            StudentModel std = new StudentModel();
            std.FirstName = "John";
            std.LastName = "Hero";
            std.Address = "NoWhere";
            std.Age = "29";
            std.College = "BMC";
            return View(std);
        }
        public IActionResult StudentList()
        {
            StudentModel std = new StudentModel();
            std.FirstName = "John";
            std.LastName = "Hero";
            std.Address = "NoWhere";
            std.Age = "29";
            std.College = "BMC";

            StudentModel std1 = new StudentModel();
            std1.FirstName = "test";
            std1.LastName = "Heasdfro";
            std1.Address = "NoWhere";
            std1.Age = "29";
            std1.College = "BMC";

            List<StudentModel> students = new List<StudentModel>();
            students.Add(std);
            students.Add(std1);
            return View(students);
        }
    }
}
