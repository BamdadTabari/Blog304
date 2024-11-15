using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Identity;
using DataProvider.EntityFramework.Repository;

namespace DataProvider.EntityFramework.Services.Identity;
public interface IRoleRepo : IRepository<Role>
{
}
public class RoleRepo(AppDbContext context) : Repository<Role>(context), IRoleRepo
{
}
