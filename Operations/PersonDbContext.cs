using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Operations.Models;

namespace Operations
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Person> People { get; set; }
    }

      
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PersonDbContext>
    {
        public PersonDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
            optionsBuilder.UseSqlServer("server=WTIN05201542L\\SQLEXPRESS;database=People;Integrated Security=SSPI;");

            return new PersonDbContext(optionsBuilder.Options);
        }
    }
}
