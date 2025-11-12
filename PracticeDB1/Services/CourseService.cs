using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDB1.Services
{
    public class CourseService
    {
        private AppDbContext dBContext {  get; set; }


        public CourseService()
        {
            dBContext = new AppDbContext();
        }

        public void AddCourses()
        {
            Course course1 = new Course();
            course1.CourseName = "Slojd";
            course1.Instructor = "Goran";

            var course2 = new Course();
            course2.CourseName = "Syslojd";
            course2.Instructor = "Stina";

            var course3 = new Course();
            course3.CourseName = "PE";
            course3.Instructor = "Ivan";

            var course4 = new Course();
            course4.CourseName = "Biology";
            course4.Instructor = "Veronica";

            var course5 = new Course();
            course5.CourseName = "Physics";
            course5.Instructor = "Andis";

            dBContext.Courses.Add(course1);
            dBContext.Courses.Add(course2);
            dBContext.Courses.Add(course3);
            dBContext.Courses.Add(course4);
            dBContext.Courses.Add(course5);

            dBContext.SaveChanges();


        }
    }
}
