using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //One student can have multiple enrollments - one to many relationship
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
