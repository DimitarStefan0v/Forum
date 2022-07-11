namespace ForumApp.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    public class CategoriesListViewModel
    {
        public IEnumerable<CategoryInListViewModel> Categories { get; set; }
    }
}
