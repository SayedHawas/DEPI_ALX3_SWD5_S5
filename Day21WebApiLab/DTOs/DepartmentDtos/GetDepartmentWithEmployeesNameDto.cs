using System.Text.Json.Serialization;

namespace Day21WebApiLab.DTOs.DepartmentDtos
{
    public class GetDepartmentWithEmployeesNameDto
    {
        [JsonIgnore]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int EmployeesCounter { get; set; }
        public List<string> EmployeeNames { get; set; } = new List<string>();
    }
}
