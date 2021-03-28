using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IUniversityGalleryService : IService<UniversityGalery>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        UniversityGalery IsActiveTrue(UniversityGalery model);
        UniversityGalery IsActiveFalse(UniversityGalery model);
        Task<IEnumerable<UniversityGalery>> GetImagesByUniversityIdAsync(int id);
    }

}
