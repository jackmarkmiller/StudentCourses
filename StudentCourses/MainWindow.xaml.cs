using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentCourses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Course> Courses = new List<Course>();
            string[] courses = File.ReadAllLines(@"C:\Users\mark7465\Downloads\Course.csv");

            System.Collections.IList list = Courses;
            for (int i = 0; i < list.Count; i++)
            {
                string c = (string)list[i];
                string[] ClassInfo = c.Split(',');
                Course studentCourses = new Course()
                {
                    CourseID = Convert.ToInt16(ClassInfo[0]),
                    CourseNumber = Convert.ToInt16(ClassInfo[1]),
                    CourseName = ClassInfo[2],
                    Subject = ClassInfo[3],
                    Instructor = ClassInfo[4]

                };
                Courses.Add(studentCourses);
            }

        }

    }
}
    

