using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUniverstyService:IService<University>
    {
        // burada Uiversity'e özel işlemler olursa yazılır (tanımlanır)
        University isActiveTrue(University _university);
        University isActiveFalse(University _university);
    }
}

