using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApiTestCrud_Po01.Controllers.DTOs;
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
        public bool CreateStudent(StudentDto studentDto)
        {
            if(_schoolContext.Students.Any(s=>s.StudentName == studentDto.StudentName))
            {
                throw new StudentException("student allready exists");
            }
            try
            {
                var student = new Student
                {
                    StudentName = studentDto.StudentName,
                    Weight = studentDto.Weight,
                    Height = studentDto.Height,
                    Grade = new()
                    {
                        GradeName = studentDto.Grade.GradeName,
                        Section = studentDto.Grade.Section
                    }
                };
                _schoolContext.Students.Add(student);
                var affectedRows = _schoolContext.SaveChanges();
                return affectedRows == studentDto.StudentID + studentDto.GradeID;
            }
            catch(Exception ex)
            {
                throw new System.Exception("blabla bla CreateStudent error");
            }
            
        }

        public bool RemoveStudent(Student student)
        {
            if (_schoolContext.Students.First(s => s.StudentID == student.StudentID )
            {
                throw new StudentException("Insert the Id of the Student to be removed");
            }
            try
            {
                var student = new Student
                {
                    StudentName = studentDto.StudentName,
                    Weight = studentDto.Weight,
                    Height = studentDto.Height,
                    Grade = new()
                    {
                        GradeName = studentDto.Grade.GradeName,
                        Section = studentDto.Grade.Section
                    }
                };
                _schoolContext.Students.Add(student);
                var affectedRows = _schoolContext.SaveChanges();
                return affectedRows == studentDto.StudentID + studentDto.GradeID;
            }
            catch (Exception ex)
            {
                throw new System.Exception("blabla bla CreateStudent error");
            }

        }
    }
}
