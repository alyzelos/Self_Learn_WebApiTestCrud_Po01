using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiTestCrud_Po01.Infrastructure;
using WebApiTestCrud_Po01.Infrastructure.Model;

namespace WebApiTestCrud_Po01
{
    public class SchoolService :ISchoolService
    {
        private readonly SchoolContext _schoolContext;

        public SchoolService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public IEnumerable<Student> GetStudentsFromDb()
        {
            var studentsFromDb = _schoolContext.Students.Include(t => t.Grade).ToList();
            return studentsFromDb;
        }
    }
}
