using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po02.Infrastructure.Model;

namespace WebApiTestCrud_Po02
{
    public class EmployeesService : IEmployeesService
    {
        private readonly EmployeesContext _employeeContext;

        public EmployeesService(EmployeesContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public IEnumerable<Employees> GetEmployeesFromDb()
        {
            var employeesFromDb = _employeeContext.Employees.ToList();
            return (IEnumerable<Employees>)employeesFromDb;
        }
    }
}
