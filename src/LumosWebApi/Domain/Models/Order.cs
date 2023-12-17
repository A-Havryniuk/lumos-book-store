using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumos.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateOnly OrderDate { get; set; }

        [Required]
        public float TotalPrice { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
