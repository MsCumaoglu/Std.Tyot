using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IAcceptedExamUniversityMapService : IService<AcceptedExamUniversityMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        AcceptedExamUniversityMap IsActiveTrue(AcceptedExamUniversityMap model);
        AcceptedExamUniversityMap isActiveFalse(AcceptedExamUniversityMap model);
        // üniversitenin kabul ettiği sinavlar
        Task<IEnumerable<AcceptedExamUniversityMap>> GetExamAcceptedAsync(int universityId);

    }
}
