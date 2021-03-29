using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UniversityService : Service<University>, IUniversityService
    {
        public UniversityService(IUnitOfWork unitOfWork, IRepository<University> repository) : base(unitOfWork, repository)
        {
        }

        public University IsActiveFalse(University entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public University IsActiveTrue(University entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}
