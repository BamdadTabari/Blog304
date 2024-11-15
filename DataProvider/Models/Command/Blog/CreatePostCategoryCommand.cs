using DataProvider.Assistant.Models;
using DataProvider.Base.Operation;
using DataProvider.EntityFramework.Entities.Blog;
using DataProvider.EntityFramework.Entities.Identity;
using System.ComponentModel.DataAnnotations;

namespace DataProvider.Models.Command.Blog;

public class CreatePostCategoryCommand
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

}
