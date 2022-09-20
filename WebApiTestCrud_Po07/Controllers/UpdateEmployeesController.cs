using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po06.Infrastructure.Model;

namespace WebApiTestCrud_Po07.Controllers
{
        [Route("{controller}")]
        [ApiController]
    public class UpdateEmployeesController
    {
        private readonly IEmployeesService _employeesService;

        public UpdateEmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpPut]
        public IActionResult Put(int id, [FromBody] Employee employee)

    }
}
