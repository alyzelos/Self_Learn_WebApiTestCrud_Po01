using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po07.Infrastructure;
using WebApiTestCrud_Po07.Infrastructure.Model;

namespace WebApiTestCrud_Po07
{
    public class EmployeesService : IEmployeesService
    {
        private readonly EmployeeContext _employeeContext;
        public EmployeesService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }



        public IEnumerable<Employee> GetEmployeesFromDb()
        {
            var employeeFromDb = _employeeContext.Employees.ToList();
            return employeeFromDb;
        }
    }
}
