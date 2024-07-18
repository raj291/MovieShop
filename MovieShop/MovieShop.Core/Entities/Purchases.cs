using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class Purchases
{
    public int MovieId { get; set; }
    public Movies Movies { get; set; }
    public int UserId { get; set; }
    public Users Users { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime PurchaseDateTime { get; set; }
    public Guid PurchaseNumber { get; set; }
    [Column(TypeName = "decimal(5,2)")] public decimal TotalPrice { get; set; }
}