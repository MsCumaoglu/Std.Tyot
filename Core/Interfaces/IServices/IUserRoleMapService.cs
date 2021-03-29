using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUserRoleMapService : IService<UserRoleMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        UserRoleMap IsActiveTrue(UserRoleMap model);
        UserRoleMap IsActiveFalse(UserRoleMap model);
    }
}