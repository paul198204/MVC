using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public decimal? Grade { get; set; }

        //every enrollment has access to one student and one course - Navigation properties
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
