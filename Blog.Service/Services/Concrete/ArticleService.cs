using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstractions;

namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ArticleViewModel>> GetAllArticlesAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleViewModel>>(articles);

            return map; 
        }
    }
}
