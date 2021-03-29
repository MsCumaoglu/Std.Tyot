using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class UniversityGalleryService : Service<UniversityGalery>, IUniversityGalleryService
    {
        public UniversityGalleryService(IUnitOfWork unitOfWork, IRepository<UniversityGalery> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<IEnumerable<UniversityGalery>> GetImagesByUniversityIdAsync(int id)
        {
            return await Where(x=>x.UinversityId== id );
        }

        public UniversityGalery IsActiveFalse(UniversityGalery entity)
        {
            //entity.IsActive = false;
            return Update(entity);
        }

        public UniversityGalery IsActiveTrue(UniversityGalery entity)
        {
            //entity.IsActive = true;
            return Update(entity);
        }

    }
}