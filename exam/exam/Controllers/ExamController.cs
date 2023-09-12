using exam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace exam.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            for(int i =0; i< 10; i++) {
                dict.Add(i, $"i am number___{i}");
            }
            
;            return View("exam",dict);
        }

        public IActionResult Testdetailview()
        {
            ExamModel exm=new ExamModel();
            exm.Id = 1;
            exm.Name = "test";
            exm.location = "kapan";
            return View(exm);
        }

        public IActionResult Testdetaillist()
        {
            ExamModel exm = new ExamModel();
            exm.Id = 1;
            exm.Name = "test";
            exm.location = "kapan";
            
            ExamModel exm1 =new ExamModel();
            exm1.Id = 2;
            exm1.Name = "test1";
            exm1.location = "chabel";

            List<ExamModel> list = new List<ExamModel>();
            list.Add(exm1);
            list.Add(exm);
            return View(list);
        }

    }
}
