using Day21WebApiLab.Models;

namespace Day21WebApiLab.Repositories
{
    public class ListDepartmentRepository : IDepartmentRepository
    {
        private static List<Department> Departments = new List<Department>()
        {
            new Department (){ DepartmentId = 1 , Name = "IT" , Description = "IT" },
            new Department (){ DepartmentId = 2 , Name = "Sales" , Description = "Sales" },
            new Department (){ DepartmentId = 3 , Name = "HR" , Description = "HR" },
            new Department (){ DepartmentId = 4 , Name = "Software" , Description = "Software" },
        };


        public IEnumerable<Department> GetAll()
        {
            return Departments.ToList();
        }

        public Department GetByID(int id)
        {
            return Departments.SingleOrDefault(i => i.DepartmentId == id);
        }

        public void Add(Department department)
        {
            Departments.Add(department);
            // _context.SaveChanges();
        }

        public void Update(Department department)
        {

            // _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = Departments.SingleOrDefault(i => i.DepartmentId == id);
            Departments.Remove(department);
            //_context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
