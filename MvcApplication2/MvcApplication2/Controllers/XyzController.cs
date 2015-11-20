using MvcApplication2.Models;
using MvcApplication2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class XyzController : Controller
    {
        SchoolContext db = new SchoolContext();
        //
        // GET: /Xyz/
        public ActionResult Abc()
        {
            var students = db.Students.ToList<Student>();
            return View(students);
            //var student1 = db.Students.ToList<Student>();
            //List<Student> list = new List<Student>();

            //Course math = new Course();
            //math.CourseName = "Math";
            //math.TotalCredits = 4;

            //Student student = new Student();
            //student.FirstName = "paul";
            //student.LastName = "Praveeen";
            //list.Add(student);

            //student = new Student();
            //student.FirstName = "paul1";
            //student.LastName = "Praveeen1";
            //list.Add(student);

            //student = new Student();
            //student.FirstName = "paul2";
            //student.LastName = "Praveeen2";
            //list.Add(student);

            //CourseStudent cstudent = new CourseStudent();
            //cstudent.students = list;
            //cstudent.course = math;

            //return View(cstudent);
        }
        public ActionResult Index()
        {
            return View();
            
        }

    }
}
