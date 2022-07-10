namespace ForumApp.Data.Models
{
    using System.Collections.Generic;

    using ForumApp.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
