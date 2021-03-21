using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IExamUniversityService : IService<ExamUniversity>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        ExamUniversity isActiveTrue(ExamUniversity _model);
        ExamUniversity isActiveFalse(ExamUniversity _model);
        ExamUniversity isStartTrue(ExamUniversity _model);
        ExamUniversity isStartFalse(ExamUniversity _model);
    }
}
