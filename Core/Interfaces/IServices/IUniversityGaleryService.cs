using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUniversityGaleryService : IService<UniversityGalery>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        UniversityGalery isActiveTrue(UniversityGalery _model);
        UniversityGalery isActiveFalse(UniversityGalery _model);
    }

}
