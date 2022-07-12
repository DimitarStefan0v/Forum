namespace ForumApp.Web.Controllers
{
    using ForumApp.Services.Data;
    using ForumApp.Web.ViewModels.Categories;
    using Microsoft.AspNetCore.Mvc;

    public class CategoriesController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new CategoriesListViewModel();
            viewModel.Categories = this.categoriesService.GetAllCategories<CategoryInListViewModel>();
            return this.View(viewModel);
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.categoriesService.GetCategoryByName<SingleCategoryViewModel>(name);
            return this.View(viewModel);
        }
    }
}
