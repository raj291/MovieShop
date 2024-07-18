namespace MovieShop.Core.Entities;

public class UserRoles
{
    public int RoleId { get; set; }
    public Roles Roles { get; set; }
    public int UserId { get; set; }
    public Users Users { get; set; }
}