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

        public IEnumerable<T> GetAll<T>(int? count = 10)
        {
            var query = this.categoriesRepository
                .All()
                .OrderBy(x => x.Title);

            if (count.HasValue)
            {
                query
                    .Take(count.Value);
            }

            return query
                .To<T>()
                .ToList();
        }
    }
}
