namespace ForumApp.Services.Data
{
    using System.Threading.Tasks;

    using ForumApp.Data.Common.Repositories;
    using ForumApp.Data.Models;
    using ForumApp.Web.ViewModels.Posts;

    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostsService(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public async Task<int> CreateAsync(PostCreateInputModel input, string userId)
        {
            var post = new Post
            {
                Title = input.Title,
                Content = input.Content,
                SubCategoryId = input.SubCategoryId,
                AddedByUserId = userId,
            };

            await this.postsRepository.AddAsync(post);
            await this.postsRepository.SaveChangesAsync();

            return post.Id;
        }
    }
}
