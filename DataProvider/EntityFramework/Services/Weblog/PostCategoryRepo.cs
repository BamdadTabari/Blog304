using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Blog;
using DataProvider.EntityFramework.Repository;

namespace DataProvider.EntityFramework.Services.Weblog;
public interface IPostCategoryRepo : IRepository<PostCategory>
{
}

public class PostCategoryRepo(AppDbContext context) : Repository<PostCategory>(context), IPostCategoryRepo
{
}