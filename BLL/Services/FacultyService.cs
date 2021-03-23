using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class FacultyService : Service<Faculty>, IFacultyService
    {
        public FacultyService(IUnitOfWork unitOfWork, IRepository<Faculty> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<IEnumerable<Faculty>> GetFacultiesByUnversityIdAsync(int id)
        {
            return await Where(x=>x.UniversityId==id);
        }

        public Faculty isActiveFalse(Faculty _entity)
        {
            _entity.IsActive = false;
            return Update(_entity);
        }

        public Faculty isActiveTrue(Faculty _entity)
        {
            _entity.IsActive = true;
            return Update(_entity);
        }
    }
}
