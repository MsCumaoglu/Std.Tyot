using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class AcceptedUniversityExamService : Service<AcceptedUniversityExam>,
        IAcceptedUniversityExamService
    {
        public AcceptedUniversityExamService(IUnitOfWork unitOfWork, IRepository<AcceptedUniversityExam> repository) : base(unitOfWork, repository)
        {
        }

        public AcceptedUniversityExam isActiveTrue(AcceptedUniversityExam _model)
        {
            throw new System.NotImplementedException();
        }

        public AcceptedUniversityExam isActiveFalse(AcceptedUniversityExam _model)
        {
            throw new System.NotImplementedException();
        }
        // üniversitenin kabul ettiği sınavlar
        public async Task<IEnumerable<AcceptedUniversityExam>> GetAcceptedExamsByUniversityIdAsync(int universityId)
        {
            return await Where(x => x.UniversityId == universityId && x.IsActive == true);
        }
        // üniversitenin sinavını kabul eden üniversiteler
        public async Task<IEnumerable<AcceptedUniversityExam>> GetExamUniversityWhereAcceptedAsync(int universityId)
        {
            return await Where(x => x.AcceptedExamUniversityId == universityId && x.IsActive==true);
        }
    }
}