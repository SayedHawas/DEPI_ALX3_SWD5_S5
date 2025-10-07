
namespace Day21WebApiLab.UnitOfWorks.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        int Complete();

    }
}
