namespace MovieShop.Core.Entities;

public class Trailers
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string Name { get; set; }
    public string TrailerUrl { get; set; }
    
    public Movies Movies { get; set; }
    
}