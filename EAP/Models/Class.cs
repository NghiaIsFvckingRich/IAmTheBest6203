using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EAP.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ClassId { get; set; }
        [Required]
        public string? ClassName { get; set; }
        public virtual Customer? Customers { get; set; }

        public Class()
        {
            //this.Customers = new HashSet<Customer>();
        }
    }
}
