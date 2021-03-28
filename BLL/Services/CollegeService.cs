using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class CollegeService : Service<College>, ICollegeService
    {
        public CollegeService(IUnitOfWork unitOfWork, IRepository<College> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<IEnumerable<College>> GetCollegesByFacultyIdAsync(int id)
        {
            return await Where(x=>x.FacultyId== id && x.isActive == true);
        }

        public College IsActiveFalse(College _entity)
        {
            _entity.isActive = false;
            return Update(_entity);
        }

        public College IsActiveTrue(College _entity)
        {
            _entity.isActive = true;
            return Update(_entity);
        }
    }
}