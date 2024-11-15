using DataProvider.EntityFramework.Configs;
using DataProvider.EntityFramework.Entities.Blog;
using DataProvider.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.EntityFramework.Services.Weblog;
public interface IPostCommentRepo : IRepository<PostComment>
{
}

public class PostCommentRepo : Repository<PostComment>, IPostCommentRepo
{
    public PostCommentRepo(AppDbContext context) : base(context)
    {
    }
}