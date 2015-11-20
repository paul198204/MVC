using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication2.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student {StudentId = 1, FirstName ="paul", LastName ="praveen"},
                new Student {StudentId = 2,FirstName ="paul1", LastName ="praveen1"},
                
            };

            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }

            var courses = new List<Course> 
            {
                new Course {CourseId = 1, CourseName = "Java"},
                new Course {CourseId = 2,CourseName = "C#"}
            };

            foreach (var temp in courses)
            {
                context.Courses.Add(temp);
            }

            var enrollments = new List<Enrollment>
            {
                new Enrollment {EnrollmentId = 1, StudentId = 1, CourseId = 1,  Grade = 3},
                new Enrollment {EnrollmentId = 2, StudentId = 1, CourseId = 2,  Grade = 4}
            };
            
            foreach (var temp in enrollments)
            {
                context.Enrollments.Add(temp);
            }

            context.SaveChanges();
        }
    }
}
