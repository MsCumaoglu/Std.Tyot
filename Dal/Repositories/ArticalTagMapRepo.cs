using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class ArticalTagMapRepo : Repository<ArticalTagMap>,
        IArticalTagMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public ArticalTagMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
