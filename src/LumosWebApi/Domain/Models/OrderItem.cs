using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumos.Domain.Models
{
    // Order - Book / one to many
    public class OrderItem
    {

        public int OrderId { get; set; }

        public int BookId { get; set; }

        public int Quantity { get; set; }

        public float SubtotalPrice { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
