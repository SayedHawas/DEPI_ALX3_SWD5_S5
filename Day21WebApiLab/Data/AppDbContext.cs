using Day21WebApiLab.Models;
using Microsoft.EntityFrameworkCore;

namespace Day21WebApiLab.Data
{
    public class AppDbContext : DbContext
    {
        #region CTORs
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        #endregion

        #region Prop
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data
            modelBuilder.Entity<Department>().HasData(
                 new Department { DepartmentId = 1, Name = "HR" },
                 new Department { DepartmentId = 2, Name = "Software" }

                );
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
