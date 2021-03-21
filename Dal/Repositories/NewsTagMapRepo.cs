using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class NewsTagMapRepo : Repository<NewsTagMap>,
        INewsTagMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public NewsTagMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
