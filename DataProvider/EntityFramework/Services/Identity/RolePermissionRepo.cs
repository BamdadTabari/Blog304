using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Identity;
using DataProvider.EntityFramework.Repository;

namespace DataProvider.EntityFramework.Services.Identity;

public interface IRolePermissionRepo : IRepository<RolePermission>
{
}
public class RolePermissionRepo(AppDbContext context) : Repository<RolePermission>(context), IRolePermissionRepo
{
}
