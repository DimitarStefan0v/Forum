namespace ForumApp.Web.Controllers
{
    using ForumApp.Services.Data;
    using ForumApp.Web.ViewModels.Categories;
    using ForumApp.Web.ViewModels.SubCategories;
    using Microsoft.AspNetCore.Mvc;

    public class SubCategoriesController : BaseController
    {
        private readonly ISubCategoriesService subCategoriesService;

        public SubCategoriesController(ISubCategoriesService subCategoriesService)
        {
            this.subCategoriesService = subCategoriesService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.subCategoriesService.GetSubCategoryByName<SubCategoriesInCategoryViewModel>(name);
            return this.View(viewModel);
        }
    }
}
