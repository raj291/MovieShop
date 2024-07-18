using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class Reviews
{
    public int MovieId { get; set; }
    public Movies Movies { get; set; }
    public int UserId { get; set; }
    public Users Users { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime CreatedDate { get; set; }
    [Column(TypeName = "decimal(3,2)")]
    public decimal Rating { get; set; }
    public string ReviewText { get; set; }
}