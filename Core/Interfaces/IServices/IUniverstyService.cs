using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUniversityService:IService<University>
    {
        // burada Uiversity'e özel işlemler olursa yazılır (tanımlanır)
        University IsActiveTrue(University university);
        University IsActiveFalse(University university);
    }
}

