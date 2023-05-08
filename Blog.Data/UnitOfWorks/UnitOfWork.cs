using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;

namespace Blog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await context.DisposeAsync();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(context);
        }
    }
}
