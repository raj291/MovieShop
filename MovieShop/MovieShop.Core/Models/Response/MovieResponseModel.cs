using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Models.Response;

public class MovieResponseModel
{
    public int Id { get; set; }
    [MaxLength(2084)]
    public string? BackdropUrl { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Budget { get; set; }
    public string? CreatedBy { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime? CreatedDate { get; set; }
    [MaxLength(2084)]
    public string? ImdbUrl { get; set; }
    [MaxLength(64)]
    public string? OriginalLanguage { get; set; }
    public string? Overview { get; set; }
    [MaxLength(2084)]
    public string? PosterUrl { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal? Price { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime ReleaseDate { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Revenue { get; set; }
    public int? RunTime { get; set; }
    [MaxLength(512)]
    public string? Tagline { get; set; }
    public string? Title { get; set; }
    public string? TmdbUrl { get; set; }
    public string? UpdatedBy { get; set; }
    [Column(TypeName ="datetime2")]
    public DateTime? UpdatedDate { get; set; }
    
    public List<TrailerResponseModel> Trailers { get; set; }
    public List<CastResponseModel> Casts { get; set; }
}