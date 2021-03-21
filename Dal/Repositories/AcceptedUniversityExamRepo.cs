using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class AcceptedUniversityExamRepo : Repository<AcceptedUniversityExam>,
        IAcceptedUniversityExamRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public AcceptedUniversityExamRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
