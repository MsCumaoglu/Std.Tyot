using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class NewsRepo : Repository<News>,
        INewsRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public NewsRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
