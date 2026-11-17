namespace day6_movie.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        //Navigation property

        public ICollection<Movie>? Movies { get; set;}
    }
}
