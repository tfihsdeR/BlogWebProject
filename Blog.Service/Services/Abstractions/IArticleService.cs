using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleViewModel>> GetAllArticlesAsync();
    }
}
