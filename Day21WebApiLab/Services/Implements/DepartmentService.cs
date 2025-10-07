using Day21WebApiLab.Services.Interfaces;
using Day21WebApiLab.UnitOfWorks.Interface;

namespace Day21WebApiLab.Services.Implements
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _unitOfWork.DepartmentRepository.GetAll();
        }
        public Department GetDepartmentByID(int id)
        {
            return _unitOfWork.DepartmentRepository.GetByID(id);
        }
        public void AddDepartment(Department department)
        {
            _unitOfWork.DepartmentRepository.Add(department);
            _unitOfWork.Complete();
        }
        public void UpdateDepartment(Department department)
        {
            _unitOfWork.DepartmentRepository.Update(department);
            _unitOfWork.Complete();
        }
        public void DeleteDepartment(int id)
        {
            var department = _unitOfWork.DepartmentRepository.GetByID(id);
            if (department != null)
            {
                _unitOfWork.DepartmentRepository.Delete(id);
                _unitOfWork.Complete();
            }
        }
        public int GetDepartmentCounter()
        {
            return _unitOfWork.DepartmentRepository.RowCount();
        }

    }
}
