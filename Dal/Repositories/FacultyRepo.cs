using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class FacultyRepo : Repository<Faculty>,
        IFacultyRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public FacultyRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
