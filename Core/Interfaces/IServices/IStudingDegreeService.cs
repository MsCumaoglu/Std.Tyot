using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IStudingDegreeService : IService<StudingDegree>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        StudingDegree IsActiveTrue(StudingDegree model);
        StudingDegree IsActiveFalse(StudingDegree model);
    }
}
