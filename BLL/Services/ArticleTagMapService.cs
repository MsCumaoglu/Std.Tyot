using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class ArticleTagMapService : Service<ArticalTagMap>, IArticleTagMapService
    {
        public ArticleTagMapService(IUnitOfWork unitOfWork, IRepository<ArticalTagMap> repository) : base(unitOfWork, repository)
        {
        }

        public ArticalTagMap IsActiveTrue(ArticalTagMap model)
        {
            model.IsActive = true;
            return Update(model);
        }

        public ArticalTagMap IsActiveFalse(ArticalTagMap model)
        {
            model.IsActive = false;
            return Update(model);
        }

        public async Task<IEnumerable<ArticalTagMap>> GetByArticleIdAsync(int id)
        {
            return await Where(x => x.ArticalId == id);
        }

        public async Task<IEnumerable<ArticalTagMap>> GetByTagIdAsync(int id)
        {
            return await Where(x => x.TagId == id);
        }
    }
}