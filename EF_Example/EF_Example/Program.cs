using System;
using System.Linq;

namespace EF_Example
{
    class Program
    {

        static void Main(string[] args)
        {
            ReadStudents();
            WriteStudents();
            ReadStudents();
        }

        private static void WriteStudents()
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    StudentID = 5,
                    StudentName = "Tom Hanks"
                };
                context.Add(student);
                int records = context.SaveChanges();

                Console.WriteLine($"{records} record added");
            }
            Console.WriteLine();
        }

        private static void ReadStudents()
        {
            using (var context = new StudentContext())
            {
                var _students = context.Students.Where(b=>b.StudentID == 1);
                foreach(var student in _students)
                {
                    Console.WriteLine($"ID:{student.StudentID} Name:{student.StudentName}");
                }
            }
            Console.WriteLine();
        }

    }
}
