namespace ForumApp.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using ForumApp.Data.Common.Repositories;
    using ForumApp.Data.Models;
    using ForumApp.Services.Mapping;
    using ForumApp.Web.ViewModels.SubCategories;

    public class SubCategoriesService : ISubCategoriesService
    {
        private readonly IDeletableEntityRepository<SubCategory> subCategoriesRepository;

        public SubCategoriesService(IDeletableEntityRepository<SubCategory> subCategoriesRepository)
        {
            this.subCategoriesRepository = subCategoriesRepository;
        }

        public async Task<int> CreateAsync(SubCategoryInputModel input, string userId)
        {
            var subCategory = new SubCategory
            {
                Title = input.Title,
                Description = input.Description,
                CategoryId = input.CategoryId,
                AddedByUserId = userId,
            };

            await this.subCategoriesRepository.AddAsync(subCategory);
            await this.subCategoriesRepository.SaveChangesAsync();

            return subCategory.Id;
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
