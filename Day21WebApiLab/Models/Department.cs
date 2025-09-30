using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day21WebApiLab.Models
{
    [Table("TblDepartments")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Must Enter Name ...")]
        [MaxLength(150)]
        public string Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }

        public string? ManagerName { get; set; }
        // Navigation Property
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
