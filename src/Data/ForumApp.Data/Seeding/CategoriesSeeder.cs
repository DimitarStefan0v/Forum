namespace ForumApp.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ForumApp.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<string>
            {
                "Education",
                "Technology",
                "Learning to Program",
                "Computer Programming",
                "Television Series",
                "Movies",
                "Mathematics",
                "Self-Improvement",
                "Healthy Lifestyle",
                "Sport",
                "Politics",
                "Coronavirus",
                "News",
            };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category,
                    Title = category,
                    Description = category,
                });
            }
        }
    }
}
