using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Identity;
using DataProvider.EntityFramework.Repository;

namespace DataProvider.EntityFramework.Services.Identity;
public interface IPermissionRepo : IRepository<Permission>
{
}
public class PermissionRepo(AppDbContext context) : Repository<Permission>(context), IPermissionRepo
{
}
