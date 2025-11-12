using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDB1.Services
{
    public class StudentService
    {
        private AppDbContext dbContext { get; set; }


        public StudentService()
        {
            dbContext = new AppDbContext();
        }

        public void AddStudents()
        {
            Student student1 = new Student();
            student1.FirstName = "Kevin";
            student1.LastName = "Larsson";
            student1.Email = "google@microsoft.com";

            Student student2 = new Student();
            student2.FirstName = "Annie";
            student2.LastName = "Langen";
            student2.Email = "microsoft@gmail.com";

            Student student3 = new Student();
            student3.FirstName = "Jan";
            student3.LastName = "Bomsson";
            student3.Email = "jesus@lover.now";

            var student4 = new Student();
            student4.FirstName = "Magda";
            student4.LastName = "Jönsson";
            student4.Email = "tv4@tv3.com";
            
            var student5 = new Student();
            student5.FirstName = "josef";
            student5.LastName = "Jonsson";
            student5.Email = "Jones@google.com";

            dbContext.Students.Add(student1);
            dbContext.Students.Add(student2);
            dbContext.Students.Add(student3);
            dbContext.Students.Add(student4);
            dbContext.Students.Add(student5);

            dbContext.SaveChanges();
            Console.WriteLine("Students added!");
        }
    }

}
