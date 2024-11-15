using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Identity;
using DataProvider.EntityFramework.Repository;

namespace DataProvider.EntityFramework.Services.Identity;
public interface IClaimRepo : IRepository<Claim>
{
}

public class ClaimRepo(AppDbContext context) : Repository<Claim>(context), IClaimRepo
{
}