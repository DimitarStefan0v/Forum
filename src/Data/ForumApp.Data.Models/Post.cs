namespace ForumApp.Data.Models
{
    using System.Collections.Generic;

    using ForumApp.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
