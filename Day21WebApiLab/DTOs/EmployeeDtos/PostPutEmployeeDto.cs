using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Day21WebApiLab.DTOs.EmployeeDtos
{
    public class PostPutEmployeeDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Must Enter Employee Name ")]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Must Enter Job")]
        [MaxLength(100)]
        public string Job { get; set; }
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        public decimal Salary { get; set; }
        public int departmentId { get; set; }

    }
}
