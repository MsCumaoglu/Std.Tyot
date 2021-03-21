using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class ArticalRepo : Repository<Artical>,
        IArticalRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public ArticalRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
