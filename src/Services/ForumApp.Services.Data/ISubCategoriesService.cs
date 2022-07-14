namespace ForumApp.Services.Data
{
    public interface ISubCategoriesService
    {
        T GetSubCategoryByName<T>(string name);
    }
}
