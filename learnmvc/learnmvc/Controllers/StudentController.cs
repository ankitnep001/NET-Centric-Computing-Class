using Microsoft.AspNetCore.Mvc;
using learnmvc.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Net;
using Microsoft.Data.SqlClient;

namespace learnmvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            StudentModel prishni = new StudentModel();
            prishni.FirstName = "sudikshya";
            prishni.LastName = "kafle";
            prishni.Age = 22;
            StudentModel ghimire = new StudentModel();
            ghimire.FirstName = "smriti";
            ghimire.LastName = "paudel";
            ghimire.Age = 21;
            List<StudentModel> students = new List<StudentModel>();
            students.Add(prishni);
            students.Add(ghimire);
            return View(students);
        }
        public IActionResult SingleStudentDetails()
        {
            StudentModel prishni = new StudentModel();
            prishni.FirstName = "prishni";
            prishni.LastName = "ghimire";
            prishni.Age = 22;
            return View(prishni);
        }

        public IActionResult AddStudent()
        {
            StudentController stdInfo = new StudentController();
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(StudentsModel std)
        {
            string ConnectionString = "Data Source=(localdb)\\ProjectModels;InitialCatalog =\"Labsheet Database\";Integrated Security=True;ConnectTimeout = 30; Encrypt = False; Trust Server Certificate = False; ApplicationIntent = ReadWrite; Multi Subnet Failover = False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            String Command = "Insert into Students(StudentName, Course, Address) values('" + std.StudentName + "', '" +std.Course + "','" + std.Address + "')";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            //return ListStudent();
            return RedirectToAction("ListStudent");
            // return View();
        }


    }
}
