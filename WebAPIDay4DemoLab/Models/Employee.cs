using System.ComponentModel.DataAnnotations;

namespace WebAPIDay4DemoLab.Models
{
    public class Employee
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]//.Identity)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Job { get; set; }
        [Required]
        [DataType("decimal(9,2")]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        [Range(0, 9999999.99)]
        public decimal Salary { get; set; }
    }
}
