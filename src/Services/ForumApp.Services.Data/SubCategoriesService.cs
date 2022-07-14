namespace ForumApp.Services.Data
{
    using ForumApp.Data.Common.Repositories;
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SubCategoriesService : ISubCategoriesService
    {
        private readonly IDeletableEntityRepository<SubCategory> subCategoriesRepository;

        public SubCategoriesService(IDeletableEntityRepository<SubCategory> subCategoriesRepository)
        {
            this.subCategoriesRepository = subCategoriesRepository;
        }

        public T GetSubCategoryByName<T>(string name)
        {
            var searchName = name.Replace('-', ' ').Trim();

            return this.subCategoriesRepository
                .AllAsNoTracking()
                .Where(x => x.Name == searchName)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
