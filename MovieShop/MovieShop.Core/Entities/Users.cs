using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class Users
{
    public int Id { get; set; }
    [Column(TypeName ="datetime2")]
    public DateTime? DateOfBirth { get; set; }
    [MaxLength(256)]    
    public string Email { get; set; }
    [MaxLength(128)]
    public string FirstName { get; set; }
    [MaxLength(1024)] public string HashedPassword { get; set; }
    public bool? IsLocked { get; set; }
    [MaxLength(128)]
    public string LastName { get; set; }
    [MaxLength(16)]
    public string? PhoneNumber { get; set; }
    public string? ProfilePictureUrl { get; set; }
    [MaxLength(1024)]
    public string Salt { get; set; }

    public List<Favorites> FavoritesList { get; set; }
    public List<Reviews> ReviewsList { get; set; }
    public List<Purchases> PurchasesList { get; set; }
    public List<UserRoles> UserRolesList { get; set; }
}