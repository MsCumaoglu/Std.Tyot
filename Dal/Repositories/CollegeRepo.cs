using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class CollegeRepo : Repository<College>,
        ICollegeRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public CollegeRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
