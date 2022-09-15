using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTestCrud_Po07.Dtos;

namespace WebApiTestCrud_Po07.Controllers
{
    [Route("{controller}")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }
        [HttpGet]
        public IActionResult Get()
        
            {
                var employeesFromDb = _employeesService.GetEmployeesFromDb();
                var employeesDto = employeesFromDb.Select(emp => new EmployeeDto
                {
                    ID = emp.ID,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Gender = emp.Gender,
                    Salary = emp.Salary,
                });
                return Ok(employeesDto);
            }
        

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var employeesFromDb = _employeesService.GetEmployeesFromDb().FirstOrDefault(s => s.ID == id);
            return Ok(employeesFromDb);
        }
    }
}
