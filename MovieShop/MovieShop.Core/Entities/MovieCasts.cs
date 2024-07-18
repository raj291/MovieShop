namespace MovieShop.Core.Entities;

public class MovieCasts
{
    public int CastId { get; set; }
    public Casts Casts { get; set; }
    public string Character { get; set; }
    public int MovieId { get; set; }
    public Movies Movies { get; set; }
}