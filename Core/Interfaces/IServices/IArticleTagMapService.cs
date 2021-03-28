using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Interfaces.IServices
{
    public interface IArticleTagMapService : IService<ArticalTagMap>
    {
        // burada Exam'e özel işlemler olursa yazılır (tanımlanır)
        ArticalTagMap IsActiveTrue(ArticalTagMap model);
        ArticalTagMap IsActiveFalse(ArticalTagMap model);
        Task<IEnumerable<ArticalTagMap>> GetByArticleIdAsync(int id);
        Task<IEnumerable<ArticalTagMap>> GetByTagIdAsync(int id);


    }
}
