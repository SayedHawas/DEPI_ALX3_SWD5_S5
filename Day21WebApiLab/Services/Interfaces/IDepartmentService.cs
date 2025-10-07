namespace Day21WebApiLab.Services.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartmentByID(int id);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
        int GetDepartmentCounter();
    }
}
