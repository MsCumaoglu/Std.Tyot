using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class NewsService : Service<News>, INewsService
    {
        public NewsService(IUnitOfWork unitOfWork, IRepository<News> repository) : base(unitOfWork, repository)
        {
        }
        public News IsActiveFalse(News entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }
        public News IsActiveTrue(News entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
    public class NewsTagMapService : Service<NewsTagMap>, INewsTagMapService
    {
        public NewsTagMapService(IUnitOfWork unitOfWork, IRepository<NewsTagMap> repository) : base(unitOfWork, repository)
        {
        }

        public NewsTagMap IsActiveTrue(NewsTagMap entity)
        {

            entity.IsActive = true;
            return Update(entity);
        }

        public NewsTagMap IsActiveFalse(NewsTagMap entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }
    }
}