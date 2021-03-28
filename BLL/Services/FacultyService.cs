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

        public async Task<IEnumerable<Faculty>> GetFacultiesByUniversityIdAsync(int id)
        {
            return await Where(x=>x.UniversityId==id && x.IsActive==true);
        }

        public Faculty IsActiveFalse(Faculty entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public Faculty IsActiveTrue(Faculty entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}
