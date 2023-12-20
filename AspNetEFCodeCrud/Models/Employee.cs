using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEFCodeCrud.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [StringLength(255)]
        public string? FirstName { get; set; }
        [StringLength(255)]
        public string? LastName { get; set; }
        [StringLength(255)]
        [EmailAddress]
        public string? Email { get; set; }
        [StringLength(50)]
        public string? Gender { get; set; } 
        public int Age { get; set; }
        [StringLength(255)]
        public string? Photo { get; set; }

    }
}
