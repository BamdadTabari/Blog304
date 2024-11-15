using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Blog;
using DataProvider.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.EntityFramework.Services.Weblog;
public interface IPostCategoryRepo: IRepository<PostCategory>
{
}

public class PostCategoryRepo : Repository<PostCategory>, IPostCategoryRepo
{
    public PostCategoryRepo(AppDbContext context) : base(context)
    {
    }
}