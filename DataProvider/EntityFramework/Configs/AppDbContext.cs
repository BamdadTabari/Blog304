using DataProvider.EntityFramework.Entities.Identity.Permissions;
using DataProvider.EntityFramework.Entities.Identity.Roles;
using DataProvider.EntityFramework.Entities.Identity.Users;
using DataProvider.EntityFramework.Seeding.IdentitySeeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace DataProvider.EntityFramework.Configs;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // Apply Configurations
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        modelBuilder.Entity<UserRole>().HasData(UserRoleSeed.All);
        modelBuilder.Entity<Role>().HasData(RoleSeed.All);
        modelBuilder.Entity<User>().HasData(UserSeed.All);
        modelBuilder.Entity<Permission>().HasData(PermissionSeed.All);
        modelBuilder.Entity<RolePermission>().HasData(RolePermissionSeed.All);
        // Creating Model
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        base.OnConfiguring(optionsBuilder);
    }
}
