using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Lumos.Domain.Models
{
    public class Book
    {

        public int BookId { get; set; }


        public string Title { get; set; }

        public string Author { get; set; }

        public int PublisherId { get; set; }

        public int GenreId { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }

        public int QuantityInStock { get; set; }

        public DateOnly PublicationDate { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public int DiscountPercentage { get; set; }

        public float AverageRating { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
    }
}
