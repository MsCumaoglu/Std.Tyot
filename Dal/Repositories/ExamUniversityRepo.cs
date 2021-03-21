using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class ExamUniversityRepo : Repository<ExamUniversity>,
        IExamUniversityRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public ExamUniversityRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
