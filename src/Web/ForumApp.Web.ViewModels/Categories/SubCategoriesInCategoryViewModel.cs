namespace ForumApp.Web.ViewModels.Categories
{
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class SubCategoriesInCategoryViewModel : IMapFrom<SubCategory>
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UserUserName { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-').ToLower()}";

        // TODO: add image
        public ICollection<PostsInSubCategoryViewModel> Posts { get; set; }
    }
}
