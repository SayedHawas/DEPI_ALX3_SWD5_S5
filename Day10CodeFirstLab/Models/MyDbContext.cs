using Microsoft.EntityFrameworkCore;

namespace Day10CodeFirstLab.Models
{
    //Database 
    public class MyDbContext : DbContext
    {
        // Table collection Row = Employee
        public DbSet<Employee> Employees { get; set; }
        //Connection String
        //Configuration 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=SAYEDHAWAS\DEPI2025R3G2;Initial Catalog=EFCodeFirstDB;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
