using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IExamLanguageMapService : IService<ExamLanguageMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        ExamLanguageMap isActiveTrue(ExamLanguageMap _model);
        ExamLanguageMap isActiveFalse(ExamLanguageMap _model);
        ExamLanguageMap isStartTrue(ExamLanguageMap _model);
        ExamLanguageMap isStartFalse(ExamLanguageMap _model);
    }
}
