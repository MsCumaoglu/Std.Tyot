using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IAcceptedUniversityExamService : IService<AcceptedUniversityExam>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        AcceptedUniversityExam isActiveTrue(AcceptedUniversityExam _model);
        AcceptedUniversityExam isActiveFalse(AcceptedUniversityExam _model);
        AcceptedUniversityExam isStartTrue(AcceptedUniversityExam _model);
        AcceptedUniversityExam isStartFalse(AcceptedUniversityExam _model);
    }
}
