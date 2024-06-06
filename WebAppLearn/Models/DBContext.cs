using Microsoft.EntityFrameworkCore;

namespace WebAppLearn.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }

    }
}
