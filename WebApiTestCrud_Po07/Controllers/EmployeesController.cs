using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTestCrud_Po07.Infrastructure.Model;

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
            return Ok(employeesFromDb);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var employeesFromDb = _employeesService.GetEmployeesFromDb().FirstOrDefault(s => s.ID == id);
            return Ok(employeesFromDb);
        }
        
        [HttpPost()]
        public IActionResult Post(Employee employees )
        {
            var employeesFromDb = _employeesService.GetEmployeesFromDb().Where(s => s.FirstName == employees.FirstName);


            return NoContent();
        }

        //[HttpPut("{id:int}")]

        //[HttpDelete("{id:int}")]

    }
}
