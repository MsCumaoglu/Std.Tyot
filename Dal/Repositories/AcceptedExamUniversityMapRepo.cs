using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class AcceptedExamUniversityMapRepo : Repository<AcceptedExamUniversityMap>, 
        IAcceptedExamUniversityMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public AcceptedExamUniversityMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
