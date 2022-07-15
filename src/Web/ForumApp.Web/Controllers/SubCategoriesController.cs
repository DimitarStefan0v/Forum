namespace ForumApp.Web.Controllers
{
    using System.Threading.Tasks;

    using ForumApp.Data.Models;
    using ForumApp.Services.Data;
    using ForumApp.Web.ViewModels.SubCategories;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class SubCategoriesController : BaseController
    {
        private readonly ISubCategoriesService subCategoriesService;
        private readonly UserManager<ApplicationUser> userManager;

        public SubCategoriesController(
            ISubCategoriesService subCategoriesService,
            UserManager<ApplicationUser> userManager)
        {
            this.subCategoriesService = subCategoriesService;
            this.userManager = userManager;
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
        public async Task<IActionResult> Create(SubCategoryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.subCategoriesService.CreateAsync(input, user.Id);
            return this.Redirect("/");
        }
    }
}
