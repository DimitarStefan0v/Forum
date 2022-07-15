namespace ForumApp.Services.Data
{
    using System.Threading.Tasks;

    using ForumApp.Web.ViewModels.Posts;

    public interface IPostsService
    {
        Task CreateAsync(PostCreateInputModel input, string userId);
    }
}
