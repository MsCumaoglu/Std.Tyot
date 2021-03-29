using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class StudingDegreeService : Service<StudingDegree>, IStudingDegreeService
    {
        public StudingDegreeService(IUnitOfWork unitOfWork, IRepository<StudingDegree> repository) : base(unitOfWork, repository)
        {
        }


        public StudingDegree IsActiveTrue(StudingDegree model)
        {
            throw new System.NotImplementedException();
        }

        public StudingDegree IsActiveFalse(StudingDegree model)
        {
            throw new System.NotImplementedException();
        }
    }
}