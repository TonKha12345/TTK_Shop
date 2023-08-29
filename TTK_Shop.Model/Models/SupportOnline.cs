using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TTK_Shop.Model.Models
{
    [Table("SupportOnline")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string Department { get; set; }

        [Required]
        [MaxLength(250)]
        public string Skype { get; set; }

        [Required]
        [MaxLength(250)]
        public string Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string Facebook { get; set; }

        [Required]
        [MaxLength(250)]
        public string Phone { get; set; }

        [Required]
        public bool? Status { get; set; }
    }
}