namespace ForumApp.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;
    using ForumApp.Web.ViewModels.SubCategories;

    public class SingleCategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public ICollection<SubCategoriesInCategoryViewModel> SubCategories { get; set; }
    }
}
