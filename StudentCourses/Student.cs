using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public List<Course> Courses { get; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            StudentID = 0;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);

        }

        public override string ToString()
        {

            return "Student:" + FirstName + " " + LastName + " " + StudentID + " " + Courses ;
        }
    }
}
