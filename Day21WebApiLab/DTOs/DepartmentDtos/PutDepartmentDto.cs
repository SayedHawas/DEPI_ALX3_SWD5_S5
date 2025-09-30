using System.ComponentModel.DataAnnotations;

namespace Day21WebApiLab.DTOs.DepartmentDtos
{
    public class PutDepartmentDto
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Must Enter Name ...")]
        [MaxLength(150)]
        public string Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        public string? ManagerName { get; set; }
    }
}
