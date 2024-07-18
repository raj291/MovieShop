using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class Roles
{
    public int Id { get; set; }
    [MaxLength(20)]
    public string Name { get; set; }

    public List<UserRoles> UsersList { get; set; }
}