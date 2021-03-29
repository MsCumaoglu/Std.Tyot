using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UserRoleMapService : Service<UserRoleMap>, IUserRoleMapService
    {
        public UserRoleMapService(IUnitOfWork unitOfWork, IRepository<UserRoleMap> repository) : base(unitOfWork, repository)
        {
        }

        public UserRoleMap IsActiveFalse(UserRoleMap entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public UserRoleMap IsActiveTrue(UserRoleMap entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}