namespace ForumApp.Web.ViewModels.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PostCreateInputModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int SubCategoryId { get; set; }
    }
}
