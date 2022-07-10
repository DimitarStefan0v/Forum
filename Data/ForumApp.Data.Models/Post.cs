namespace ForumApp.Data.Models
{
    using ForumApp.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
