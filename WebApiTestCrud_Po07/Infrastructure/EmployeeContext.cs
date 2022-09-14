using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTestCrud_Po07.Infrastructure.Model;

namespace WebApiTestCrud_Po07.Infrastructure
{
    public class EmployeeContext : DbContext
    {

        public static readonly LoggerFactory _myLoggerFactory = new(new[] { new DebugLoggerProvider() });
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
