namespace MovieShop.Core.Models.Response;

public class TrailerResponseModel
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string Name { get; set; }
    public string TrailerUrl { get; set; }
}