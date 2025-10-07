using Day21WebApiLab.Models;

namespace Day21WebApiLab.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetByID(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id);
        void Save();

    }
}
