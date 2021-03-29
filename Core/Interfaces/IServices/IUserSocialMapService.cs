using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUserSocialMapService : IService<UserSocialMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        UserSocialMap IsActiveTrue(UserSocialMap model);
        UserSocialMap IsActiveFalse(UserSocialMap model);
    }
}