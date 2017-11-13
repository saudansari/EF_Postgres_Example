using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Example
{
    [Table("student")]
    public class Student
    {
        [Column("STUDENT_ID")]
        public int      StudentID       { get; set; }
        [Column("STUDENT_NAME")]
        public string   StudentName     { get; set; }
    }
}
