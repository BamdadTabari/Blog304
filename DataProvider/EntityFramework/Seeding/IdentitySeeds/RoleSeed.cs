using DataProvider.EntityFramework.Entities.Identity.Roles;

namespace DataProvider.EntityFramework.Seeding.IdentitySeeds;

public static class RoleSeed
{
    public static List<Role> All => new List<Role>
    {
        new Role()
        {
            Id = 1,
            Title = "Owner",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
        }
    };
}