using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace EFCodeFirstDay18Lab.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Must Enter Name")]
        [StringLength(50, ErrorMessage = "up to 50 characters only", MinimumLength = 6)]
        public string Name { get; set; }



        [DisplayFormat(DataFormatString = "{0:P}")]
        public decimal Score { get; set; }
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Code { get; set; }

        [Range(17, 21, ErrorMessage = "between 17 and 21")]
        public int Age { get; set; }

        [RegularExpression("^[a-zA-Z]{6}$", ErrorMessage = "Enter 6  Letter only ")]
        public string Group { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; } = string.Empty;
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [NotMapped]
        [IgnoreDataMember]
        [FileExtensions(Extensions = ".jpg,.gif")]
        public byte[]? PhotoFile { get; set; }

        public string? PhotoPath { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/YYYY}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> CreateDate { get; set; }
        public DateTime? CreateDate { get; set; } = null;

        [Range(typeof(decimal), "1000.50", "100000.50")]
        [CreditCard]
        public decimal Credit { get; set; }

    }
}
