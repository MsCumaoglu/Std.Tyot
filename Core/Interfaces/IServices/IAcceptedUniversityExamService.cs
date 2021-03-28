using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IAcceptedUniversityExamService : IService<AcceptedUniversityExam>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        AcceptedUniversityExam isActiveTrue(AcceptedUniversityExam _model);
        AcceptedUniversityExam isActiveFalse(AcceptedUniversityExam _model);
        // üniversitenin kabul ettiği sınavlar
        Task<IEnumerable<AcceptedUniversityExam>> GetAcceptedExamsByUniversityIdAsync(int _universityId);
        // üniversitenin sinavını kabul eden üniversiteler
        Task<IEnumerable<AcceptedUniversityExam>> GetExamUniversityWhereAcceptedAsync(int _universityId);


    }
}
