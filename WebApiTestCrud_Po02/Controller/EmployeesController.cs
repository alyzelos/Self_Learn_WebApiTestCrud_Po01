using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTestCrud_Po02.Controller
{
    [Route("{controller}")]
    [ApiController]
    public class EmployeesController : ControllerContext
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
            return OkResult(employeesFromDb);
        }
    }
}
