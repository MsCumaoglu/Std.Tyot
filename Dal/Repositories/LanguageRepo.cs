using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class LanguageRepo : Repository<Language>,
        ILanguageRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public LanguageRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
    public class LanguageCollegeMapRepo : Repository<LanguageCollegeMap>,
        ILanguageCollegeMapRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public LanguageCollegeMapRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
