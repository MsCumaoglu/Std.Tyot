using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ILnaguageUniversityMapService : IService<LnaguageUniversityMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        LnaguageUniversityMap isActiveTrue(LnaguageUniversityMap _model);
        LnaguageUniversityMap isActiveFalse(LnaguageUniversityMap _model);
    }
}
