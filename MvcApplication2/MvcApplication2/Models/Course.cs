using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int TotalCredits { get; set; }

        //One course can have multiple enrollments - one to many relationship
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
