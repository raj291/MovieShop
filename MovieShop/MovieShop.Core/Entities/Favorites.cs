namespace MovieShop.Core.Entities;

public class Favorites
{
    public int MovieId { get; set; }
    public Movies Movies { get; set; }
    public int UserId { get; set; }
    public Users Users { get; set; }
}