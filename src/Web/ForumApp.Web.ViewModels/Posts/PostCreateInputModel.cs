namespace ForumApp.Web.ViewModels.Posts
{
    using System.ComponentModel.DataAnnotations;

    public class PostCreateInputModel
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public int SubCategoryId { get; set; }
    }
}
