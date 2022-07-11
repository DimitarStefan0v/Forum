namespace ForumApp.Web.ViewModels.Categories
{
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class CategoryInListViewModel : IMapFrom<Category>
    {
        public string Title { get; set; }

        public string Name { get; set; }
    }
}
