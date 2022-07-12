namespace ForumApp.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class SubCategoriesInCategoryViewModel : IMapFrom<SubCategory>
    {
        public string Title { get; set; }

        public string Name { get; set; }
        

    }
}
