using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class AcceptedExamUniversityMapService : Service<AcceptedExamUniversityMap>,
        IAcceptedExamUniversityMapService
    {
        public AcceptedExamUniversityMapService(IUnitOfWork unitOfWork,
            IRepository<AcceptedExamUniversityMap> repository) : base(unitOfWork, repository)
        {
        }

        public AcceptedExamUniversityMap IsActiveTrue(AcceptedExamUniversityMap model)
        {
            throw new System.NotImplementedException();
        }

        public AcceptedExamUniversityMap isActiveFalse(AcceptedExamUniversityMap model)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<AcceptedExamUniversityMap>> GetExamAcceptedAsync(int universityId)
        {
            return await Where(x => x.UniversityId == universityId && x.IsActive==true);
        }
    }
}