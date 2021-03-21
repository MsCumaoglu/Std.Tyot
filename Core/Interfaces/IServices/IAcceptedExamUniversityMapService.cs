using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IAcceptedExamUniversityMapService : IService<AcceptedExamUniversityMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        AcceptedExamUniversityMap isActiveTrue(AcceptedExamUniversityMap _model);
        AcceptedExamUniversityMap isActiveFalse(AcceptedExamUniversityMap _model);
        AcceptedExamUniversityMap isStartTrue(AcceptedExamUniversityMap _model);
        AcceptedExamUniversityMap isStartFalse(AcceptedExamUniversityMap _model);
    }    }
