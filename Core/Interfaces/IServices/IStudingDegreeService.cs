using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IStudingDegreeService : IService<StudingDegree>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        StudingDegree isActiveTrue(StudingDegree _model);
        StudingDegree isActiveFalse(StudingDegree _model);
    }
}
