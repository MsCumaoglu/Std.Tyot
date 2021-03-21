using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IAcceptedExamService : IService<AcceptedExam>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Exam isActiveTrue(AcceptedExam _model);
        Exam isActiveFalse(AcceptedExam _model);
        Exam isStartTrue(AcceptedExam _model);
        Exam isStartFalse(AcceptedExam _model);
    }
}
