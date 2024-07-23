namespace MovieShop.Core.Models.Request;

public class TrailerRequestModel
{
    public int MovieId { get; set; }
    public string Name { get; set; }
    public string TrailerUrl { get; set; }
}