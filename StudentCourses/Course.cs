using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourses
{
    class Course
    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        public Course()
        {
            CourseNumber = 0;
            CourseName = "";
            Subject = "";
            Instructor = "";
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
