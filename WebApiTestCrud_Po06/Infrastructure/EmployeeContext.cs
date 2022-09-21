using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace WebApiTestCrud_Po06.Infrastructure
{
    public class EmployeeContext : DbContext
    {
        private static readonly LoggerFactory _myLoggerFactory;

        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        { }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
        }
    }
}
