using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UserSettingService : Service<UserSetting>, IUserSettingService
    {
        public UserSettingService(IUnitOfWork unitOfWork, IRepository<UserSetting> repository) : base(unitOfWork, repository)
        {
        }

        public UserSetting IsActiveFalse(UserSetting entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public UserSetting IsActiveTrue(UserSetting entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}