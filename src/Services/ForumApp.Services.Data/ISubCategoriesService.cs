namespace ForumApp.Services.Data
{
    using System.Threading.Tasks;

    using ForumApp.Web.ViewModels.SubCategories;

    public interface ISubCategoriesService
    {
        T GetSubCategoryByName<T>(string name);

        Task CreateAsync(SubCategoryInputModel input, string userId);
    }
}
