using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class UniversityRepo : Repository<University>,
        IUniversityRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public UniversityRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
