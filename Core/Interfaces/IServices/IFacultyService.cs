using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.IServices
{
    public interface IFacultyService:IService<Faculty>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Faculty IsActiveTrue(Faculty faculty);
        Faculty IsActiveFalse(Faculty faculty);
        Task<IEnumerable<Faculty>> GetFacultiesByUniversityIdAsync(int id);

    }
}
