using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po07.Infrastructure.Model;

namespace WebApiTestCrud_Po07
{
    public interface IEmployeesService
    {
        IEnumerable<Employee> GetEmployeesFromDb();

        //IEnumerable<Employee> CreateEmployee();
    }
}
