using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class SocialService : Service<Social>, ISocialService
    {
        public SocialService(IUnitOfWork unitOfWork, IRepository<Social> repository) : base(unitOfWork, repository)
        {
        }

        public Social IsActiveFalse(Social entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public Social IsActiveTrue(Social entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}