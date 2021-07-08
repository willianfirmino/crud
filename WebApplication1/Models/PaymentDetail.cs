using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar2(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [MaxLength(16)]
        [Column(TypeName = "varchar2(16)")]
        public string CardNumber{ get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime ExpirationDate{ get; set; }

        [Required]
        [MaxLength(3)]
        public string SecurityCode { get; set; }

    }
}
