using PracticeDB1.Services;

namespace PracticeDB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();

            service.AddStudents();
        }
    }
}
