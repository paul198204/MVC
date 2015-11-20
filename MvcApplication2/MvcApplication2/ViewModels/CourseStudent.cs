using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.ViewModels
{
    //ViewModels
    public class CourseStudent
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}
