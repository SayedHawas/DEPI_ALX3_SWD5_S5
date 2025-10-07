using Day21WebApiLab.Data;
using Day21WebApiLab.Models;
using Microsoft.EntityFrameworkCore;

namespace Day21WebApiLab.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public Department GetByID(int id)
        {
            return _context.Departments.Find(id);
        }

        public void Add(Department department)
        {
            _context.Departments.Add(department);
            // _context.SaveChanges();
        }

        public void Update(Department department)
        {
            _context.Entry(department).State = EntityState.Modified;
            // _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            //_context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
