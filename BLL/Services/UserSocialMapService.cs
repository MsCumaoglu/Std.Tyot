using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UserSocialMapService : Service<UserSocialMap>, IUserSocialMapService
    {
        public UserSocialMapService(IUnitOfWork unitOfWork, IRepository<UserSocialMap> repository) : base(unitOfWork, repository)
        {
        }

        public UserSocialMap IsActiveFalse(UserSocialMap entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public UserSocialMap IsActiveTrue(UserSocialMap entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}