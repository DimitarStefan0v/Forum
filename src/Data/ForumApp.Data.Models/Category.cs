namespace ForumApp.Data.Models
{
    using System.Collections.Generic;

    using ForumApp.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.SubCategories = new HashSet<SubCategory>();
        }

        public string Title { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
