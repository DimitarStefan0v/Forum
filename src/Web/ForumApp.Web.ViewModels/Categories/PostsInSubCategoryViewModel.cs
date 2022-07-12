namespace ForumApp.Web.ViewModels.Categories
{
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PostsInSubCategoryViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }

        public ICollection<CommentsInPostViewModel> Comments { get; set; }
    }
}
