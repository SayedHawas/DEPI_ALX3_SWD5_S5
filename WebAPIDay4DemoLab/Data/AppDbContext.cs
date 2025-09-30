using Microsoft.EntityFrameworkCore;
using WebAPIDay4DemoLab.Models;

namespace WebAPIDay4DemoLab.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            List<Employee> employees = new List<Employee>() {
            new Employee() { Name = "Mariem ", Job = "DR", Salary = 15000 },
            new Employee() { Name = "Retaj ", Job = "Eng", Salary = 17000 },
            new Employee() { Name = "Osama ", Job = "Teacher", Salary = 18000 }
            };
            //Seed Data
            modelBuilder.Entity<Employee>(emp =>
            {
                emp.HasKey(emp => emp.Id);
                emp.Property(e => e.Name).IsRequired().HasDefaultValue("No Name");
            });

            //modelBuilder.Entity<Employee>().HasData(employees);
        }
    }
}
