using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTestCrud_Po02.Controller
{
    [System.Web.Http.Route("{controller}")]
    [ApiController]
    public class EmployeesController : ApiController
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult Get()
        {
            var employeesFromDb = _employeesService.GetEmployeesFromDb();
            return (IActionResult)Ok(employeesFromDb);
        }
    }
}
