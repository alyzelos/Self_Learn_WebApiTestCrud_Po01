using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using WebApiTestCrud_Po01.Infrastructure.Model;

namespace WebApiTestCrud_Po01.Infrastructure
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public static readonly LoggerFactory _myLoggerFactory = new(new[] { new DebugLoggerProvider() });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_myLoggerFactory);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }
}
