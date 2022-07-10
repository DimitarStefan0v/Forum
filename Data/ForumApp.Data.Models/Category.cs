namespace ForumApp.Data.Models
{
    using ForumApp.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}
