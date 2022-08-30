using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po02.Infrastructure.Model;

namespace WebApiTestCrud_Po02
{
    public interface IEmployeesService
    {
        IEnumerable<Employees> GetEmployeesFromDb();
    }
}
