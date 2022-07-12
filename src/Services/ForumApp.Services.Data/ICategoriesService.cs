namespace ForumApp.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAllCategories<T>(int? count = null);

        T GetCategoryByName<T>(string name);
    }
}
