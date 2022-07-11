namespace ForumApp.Data.Models
{
    using System.Collections.Generic;

    using ForumApp.Data.Common.Models;

    public class SubCategory : BaseDeletableModel<int>
    {
        public SubCategory()
        {
            this.Posts = new HashSet<Post>();
        }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // TODO: add image
        public ICollection<Post> Posts { get; set; }

        public string AddedByUserId { get; set; }

        public ApplicationUser AddedByUser { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
