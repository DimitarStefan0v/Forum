namespace ForumApp.Web.ViewModels.SubCategories
{
    using System.Collections.Generic;

    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class SubCategoriesInCategoryViewModel : IMapFrom<SubCategory>
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string AddedByUserUserName { get; set; }

        public string Url => $"/community/{this.Name.Replace(' ', '-').ToLower()}";

        // TODO: add image
        // public ICollection<PostsInSubCategoryViewModel> Posts { get; set; }
    }
}
