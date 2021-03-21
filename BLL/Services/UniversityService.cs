using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UniversityService : Service<University>, IUniverstyService
    {
        public UniversityService(IUnitOfWork unitOfWork, IRepository<University> repository) : base(unitOfWork, repository)
        {
        }

        public University isActiveFalse(University _entity)
        {
            _entity.IsActive = false;
            return Update(_entity);
        }

        public University isActiveTrue(University _entity)
        {
            _entity.IsActive = true;
            return Update(_entity);
        }
    }
}
