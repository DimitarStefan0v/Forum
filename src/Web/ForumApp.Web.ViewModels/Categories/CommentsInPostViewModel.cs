namespace ForumApp.Web.ViewModels.Categories
{
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class CommentsInPostViewModel : IMapFrom<Comment>
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }
    }
}
