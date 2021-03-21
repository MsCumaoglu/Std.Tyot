using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ILanguageCollegeMapService : IService<LanguageCollegeMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        LanguageCollegeMap isActiveTrue(LanguageCollegeMap _model);
        LanguageCollegeMap isActiveFalse(LanguageCollegeMap _model);
    }
}
