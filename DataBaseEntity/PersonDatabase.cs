using EntityFrameworkConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkConsoleApp.DataBaseEntity{
    public class PersonDatabase:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Nobet;User Id=sa;Password=Pp123456*-;TrustServerCertificate=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}