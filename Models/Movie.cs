using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace day6_movie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O")]
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {  get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int GenreId { get; set; }
        //Navigation property

        public Genre? Genre { get; set; }
    }
}
