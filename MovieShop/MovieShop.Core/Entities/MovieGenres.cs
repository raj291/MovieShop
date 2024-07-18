namespace MovieShop.Core.Entities;

public class MovieGenres
{
    public int GenreId { get; set; }
    public Genres Genres { get; set; }
    public int MovieId { get; set; }
    public Movies Movies { get; set; }
}