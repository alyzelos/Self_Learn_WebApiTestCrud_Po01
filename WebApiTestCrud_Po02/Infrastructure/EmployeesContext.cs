using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTestCrud_Po02.Infrastructure.Model
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options)
        {

        }
        public static readonly LoggerFactory _myLoggerFactory = new(new[] { new DebugLoggerProvider() });
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
        }
        public DbSet<EmployeesContext> Employees { get; set; }

    }
}
