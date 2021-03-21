using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class AcceptedExamRepo : Repository<AcceptedExam>, IAcceptedExamRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public AcceptedExamRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
