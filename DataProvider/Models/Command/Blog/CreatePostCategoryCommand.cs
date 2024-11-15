using DataProvider.Assistant.Models;
using DataProvider.Base.Operation;
using DataProvider.EntityFramework.Entities.Blog;
using DataProvider.EntityFramework.Entities.Identity;

namespace DataProvider.Models.Command.Blog;

public class CreatePostCategoryCommand(RequestInfo requestInfo) : IRequestInfo
{
    public string Name { get; set; }

    // navigation
    public RequestInfo RequestInfo { get; private set; } = requestInfo;
}
