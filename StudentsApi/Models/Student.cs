using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsApi.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(120)]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
