using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Interfaces.IServices;
using Core.Models;

namespace BLL.Services
{
    public class ArticleService : Service<Artical>, IArticleService
    {
        public ArticleService(IUnitOfWork unitOfWork, IRepository<Artical> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<IEnumerable<Artical>> GetByCategoryIdAsync(int id)
        {
            return await Where(x=>x.CategoryId==id && x.IsActive==true);
        }

        public Artical IsActiveFalse(Artical entity)
        {
            entity.IsActive = false;
            return Update(entity);
        }

        public Artical IsActiveTrue(Artical entity)
        {
            entity.IsActive = true;
            return Update(entity);
        }
    }
}