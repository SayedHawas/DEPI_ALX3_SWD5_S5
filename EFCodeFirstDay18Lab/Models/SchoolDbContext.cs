using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstDay18Lab.Models
{
    internal class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {

        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=SAYEDHAWAS\\DEPI2025R3G2;Initial Catalog=Day3WebAPIDB;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(s =>
            {
                s.HasKey(b => b.Id);
                s.Property(b => b.Name).HasMaxLength(50);
            });
        }
    }
}
