using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User> repository) : base(unitOfWork, repository)
        {
        }

        public User IsActiveFalse(User entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public User IsActiveTrue(User entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}