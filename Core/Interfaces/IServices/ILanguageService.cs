using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ILanguageService : IService<Language>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Language isActiveTrue(Language _model);
        Language isActiveFalse(Language _model);
    }    
}
