using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface ICollegeService : IService<College>
    {
        // burada Bolümler'e özel işlemler olursa yazılır (tanımlanır)
        College IsActiveTrue(College _college);
        College IsActiveFalse(College _college);
        Task<IEnumerable<College>> GetCollegesByFacultyIdAsync(int id);

    }
}
