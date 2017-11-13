using System;
using System.Linq;

namespace EF_Example
{
    public class StudentService
    {
        private readonly StudentContext _studentContext;
        
        public StudentService(StudentContext studentcontext)
        {
            _studentContext = studentcontext;
        }

        public void WriteStudents()
        {
            var student = new Student
            {
                StudentID = 5,
                StudentName = "Tom Hanks"
            };
            _studentContext.Add(student);
            int records = _studentContext.SaveChanges();

            Console.WriteLine($"{records} record added");
        }

        public void ReadStudents()
        {
            var _students = _studentContext.Students.Where(b => b.StudentID == 1);
            foreach (var student in _students)
            {
                Console.WriteLine($"ID:{student.StudentID} Name:{student.StudentName}");
            }
        }


    }
}
