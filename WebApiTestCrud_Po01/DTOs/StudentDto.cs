using System;

namespace WebApiTestCrud_Po01.Controllers.DTOs
{
    public class StudentDto
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int GradeID { get; set; }
        public GradeDto Grade { get; set; }
    }
}
