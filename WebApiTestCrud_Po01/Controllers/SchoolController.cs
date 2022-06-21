using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApiTestCrud_Po01.Controllers.DTOs;

namespace WebApiTestCrud_Po01.Controllers
{
    [Route("{controller}")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var studentsFromDb = _schoolService.GetStudentsFromDb();
            var studentDtos = studentsFromDb.Select(student => new StudentDto
            {
                GradeID = student.GradeID,
                StudentID = student.StudentID,
                StudentName = student.StudentName,
            });
            return Ok(studentDtos);
        }
    }
}
