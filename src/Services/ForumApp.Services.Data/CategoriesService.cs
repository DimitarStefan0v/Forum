namespace ForumApp.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ForumApp.Data.Common.Repositories;
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<T> GetAllCategories<T>(int? count = null)
        {
            IQueryable<Category> query = this.categoriesRepository
                .All()
                .OrderBy(x => x.Title);

            if (count.HasValue)
            {
                query = query
                    .Take(count.Value);
            }

            return query
                .To<T>().ToList();
        }

        public T GetCategoryByName<T>(string name)
        {
            return this.categoriesRepository
                .All()
                .Where(x => x.Name == name)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
