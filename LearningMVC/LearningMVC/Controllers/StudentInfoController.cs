using LearningMVC.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LearningMVC.Models
{
    public class StudentInfoController : Controller
    {
        public IActionResult AddStudent()
        {
            StudentInfoController stdInfo = new StudentInfoController();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentInfoModel std)
        {
            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BMC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            String Command = "Insert into Students (StudentName,Course,Address) values('"+std.StudentName+ "','"+std.Course+ "','"+std.Address+"')";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
            //return ListStudent();
           return RedirectToAction("ListStudent");
          //  return View();
        }

        public IActionResult ListStudent()
        {
            string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BMC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();

            String Command = "Select * from Students";
            SqlCommand cmd = new SqlCommand(Command, Connection);
            SqlDataReader sr = cmd.ExecuteReader();
            List<StudentInfoModel> list = new List<StudentInfoModel>();
            while (sr.Read())
            {
                StudentInfoModel std = new StudentInfoModel();
                std.Id = Convert.ToInt32(sr["Id"]);
                std.StudentName = sr["StudentName"].ToString();
                std.Course = sr["Course"].ToString();
                std.Address = sr["Address"].ToString();
                list.Add(std);
            }
            Connection.Close();
            return View(list);
        }

    }
}
