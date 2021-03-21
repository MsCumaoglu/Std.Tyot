using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class ExamLanguageMapRepo : Repository<ExamLanguageMap>,
        IExamLanguageMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public ExamLanguageMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
