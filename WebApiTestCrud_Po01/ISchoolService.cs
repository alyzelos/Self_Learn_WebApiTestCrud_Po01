using System.Collections.Generic;
using WebApiTestCrud_Po01.Controllers.DTOs;
using WebApiTestCrud_Po01.Infrastructure.Model;

namespace WebApiTestCrud_Po01
{
    public interface ISchoolService
    {
        IEnumerable<Student> GetStudentsFromDb();
        bool CreateStudent(StudentDto studentDto);
        bool UpdateStudentThroughDTO(int id, Student student);
    }
}
