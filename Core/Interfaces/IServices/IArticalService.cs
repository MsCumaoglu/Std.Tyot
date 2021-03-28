using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IArticleService : IService<Artical>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        Artical IsActiveTrue(Artical article);
        Artical IsActiveFalse(Artical article);
        Task<IEnumerable<Artical>> GetByCategoryIdAsync(int id);
    }
}
