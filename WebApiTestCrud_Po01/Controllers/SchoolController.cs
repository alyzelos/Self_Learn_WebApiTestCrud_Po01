﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApiTestCrud_Po01.Controllers.DTOs;
using WebApiTestCrud_Po01.Infrastructure.Model;

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
        #region Get Method
        [HttpGet]
        public IActionResult Get()
        {
            var studentsFromDb = _schoolService.GetStudentsFromDb();
            var studentDtos = studentsFromDb.Select(student => new StudentDto
            {
                GradeID = student.GradeID,
                StudentID = student.StudentID,
                StudentName = student.StudentName,
                Height = student.Height,
                Grade = new()
                {
                    GradeName = student.Grade.GradeName,
                    Section = student.Grade.Section
                }
            });
            return Ok(studentDtos);
            }
        #endregion

        #region GetById Method
        // -> Method for getting information from DB by ID. 
        //-------------------------------------------------
        //[HttpGet("{id:int}")]
        //public IActionResult Get(int id)
        //{
        //    var student = _schoolService.GetStudentsFromDb().FirstOrDefault(s => s.StudentID == id);
        //    return Ok(student);
        //}
        //->Method for gettin information from DB by ID & implementing DTO's.
        //-------------------------------------------------
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var studentFromDb = _schoolService.GetStudentsFromDb().FirstOrDefault(s => s.StudentID == id);
            var studentDtos = new StudentDto
            {
                GradeID = studentFromDb.GradeID,
                StudentID = studentFromDb.StudentID,
                StudentName = studentFromDb.StudentName,
                Grade = new()
                {
                    GradeName = studentFromDb.Grade.GradeName
                }
            };
            return Ok(studentDtos);
        }
        #endregion


        [HttpPut("{id:int}")]
        public IActionResult Put(int id)
        {
            if(id == null)
            {
                return BadRequest("insert ID and try again.");
            }
            else



            return NoContent();


            #region DetailsGetMethod
            //-initial get by id value 

            //var studentFromDb = _schoolService.GetStudentsFromDb().FirstOrDefault(s => s.StudentID == id);
            //var studentDtos = new StudentDto
            //{
            //    GradeID = studentFromDb.GradeID,
            //    StudentID = studentFromDb.StudentID,
            //    StudentName = studentFromDb.StudentName,
            //    Grade = new()
            //    {
            //        GradeName = studentFromDb.Grade.GradeName
            //    }
            //};
            //return Ok(studentDtos);
            #endregion
        }
    }
}
