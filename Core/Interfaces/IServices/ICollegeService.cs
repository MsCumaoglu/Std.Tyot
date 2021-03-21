using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICollegeService : IService<College>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Exam isActiveTrue(College _college);
        Exam isActiveFalse(College _college);
        Exam isStartTrue(College _college);
        Exam isStartFalse(College _college);
    }
}
