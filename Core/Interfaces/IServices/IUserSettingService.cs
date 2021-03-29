using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUserSettingService : IService<UserSetting>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        UserSetting IsActiveTrue(UserSetting model);
        UserSetting IsActiveFalse(UserSetting model);
    }
}