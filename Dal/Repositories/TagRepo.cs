using Core.Models;
using Core.Interfaces.IRepositories;

namespace Dal.Repositories
{
    public class TagRepo : Repository<Tag>,
        ITagRepo
    {
        private TyottrContext appContext { get => _ctx as TyottrContext; }

        public TagRepo(TyottrContext ctx) : base(ctx)
        {
        }
    }
}
