using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public System.DateTime? Birthday { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? ConfirmPassword { get; set; }
        [Required]
        [ForeignKey(nameof(Class.ClassId))]
        public int ClassId { get; set; }
        public virtual Class? Classes { get; set; }
    }
}
