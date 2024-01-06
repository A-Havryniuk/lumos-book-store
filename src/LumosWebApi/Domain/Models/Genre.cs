using System.ComponentModel.DataAnnotations;


namespace Lumos.Domain.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public ICollection<Book> Books { get; set; }
    }
}
