using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IFacultyService:IService<Faculty>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Faculty isActiveTrue(Faculty _faculty);
        Faculty isActiveFalse(Faculty _faculty);
    }
}
