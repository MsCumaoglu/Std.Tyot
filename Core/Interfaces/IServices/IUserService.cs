using Core.Models;

namespace Core.Interfaces.IServices
{ 
    public interface IUserService : IService<User>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        User IsActiveTrue(User model);
        User IsActiveFalse(User model);
    }
}