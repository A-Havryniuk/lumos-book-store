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
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateOnly OrderDate { get; set; }

        public float TotalPrice { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
