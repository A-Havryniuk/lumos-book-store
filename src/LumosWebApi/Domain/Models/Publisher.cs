using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumos.Domain.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string PublisherName { get; set;}

        ICollection<Book> Books { get; set; }
    }
}
