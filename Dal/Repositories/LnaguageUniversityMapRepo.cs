using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class LnaguageUniversityMapRepo : Repository<LnaguageUniversityMap>,
        ILnaguageUniversityMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public LnaguageUniversityMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
