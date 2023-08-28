using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TTK_Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerMessage { get; set; }

        public DateTime? CreateDate { get; set; }

        [Required]
        [MaxLength(250)]
        public string CreateBy { get; set; }

        [Required]
        [MaxLength(250)]
        public string PaymentMethod { get; set; }

        [Required]
        [MaxLength(250)]
        public string PaymentStatus { get; set; }

        public bool? Status { get; set; }
    }
}