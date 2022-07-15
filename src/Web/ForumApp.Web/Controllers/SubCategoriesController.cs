namespace ForumApp.Web.Controllers
{
    using ForumApp.Services.Data;
    using ForumApp.Web.ViewModels.Categories;
    using ForumApp.Web.ViewModels.SubCategories;
    using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(SubCategoryPostInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            // TODO: add in db with service
            return this.Redirect("/");
        }
    }
}
