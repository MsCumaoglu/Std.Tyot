using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ISocialService : IService<Social>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Social IsActiveTrue(Social model);
        Social IsActiveFalse(Social model);
    }
}