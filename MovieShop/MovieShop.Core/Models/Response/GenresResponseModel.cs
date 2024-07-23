using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Models.Response;

public class GenresResponseModel
{
    public int Id { get; set; }
    [MaxLength(24)]
    public string Name { get; set; }
}