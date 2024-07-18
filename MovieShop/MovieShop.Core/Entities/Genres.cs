using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class Genres
{
    public int Id { get; set; }
    [MaxLength(24)]
    public string Name { get; set; }
    public List<MovieGenres> MovieGenresList { get; set; }
}