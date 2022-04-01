using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(TypeName = "nchar")]
        public string StudentName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "datetime")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Height { get; set; }

        [Column(TypeName = "float")]
        public float? Weight { get; set; }
    }
}
