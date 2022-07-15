namespace ForumApp.Web.Controllers
{
    using System.Threading.Tasks;

    using ForumApp.Data.Models;
    using ForumApp.Web.ViewModels.Posts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public PostsController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult ById(int id)
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PostCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            // TODO: add in db with service
            // TODO: RedirectToAction ById with parameter post.Id
            return this.Redirect("/");
        }
    }
}
