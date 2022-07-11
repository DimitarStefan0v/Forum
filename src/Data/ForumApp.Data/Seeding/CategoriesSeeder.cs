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
                "Sports",
                "Gaming",
                "News",
                "TV",
                "Pics & Gifs",
                "Travel",
                "Tech",
                "Music",
                "Art & Design",
                "Beauty",
                "Books & Writing",
                "Discussion",
                "Fashion",
                "Finance & Business",
                "Food",
                "Health & Fitness",
                "Learning",
                "Mindblowing",
                "Parenting",
                "Relationships",
                "Science",
            };

            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category,
                    Title = category,
                });
            }
        }
    }
}
