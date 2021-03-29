using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
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